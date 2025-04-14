// Ignore Spelling: FRM

using System.Windows.Forms;
using TenQuizQuestions.Models;

namespace TenQuizQuestions
{
	public partial class Game_FRM : Form
	{
		#region PublicItems
		public int RowNumber = 0;
		public int correctAnswers = 0;
		public int incAnswers = 0;
		public bool lastCorrectAnswer = false;
		public bool lastInCorrectAnswer = false;
		public int backCounter = 0;
		#endregion
		public Game_FRM()
		{
			InitializeComponent();

			Back_BTN.Enabled = false;
			Back_BTN.BackColor = System.Drawing.Color.Gray;
			Questions_LBL.Text = Questions.questions[RowNumber];
			True_RBTN.Checked = false;
			False_RBTN.Checked = false;
		}

		private void Next_BTN_Click(object sender, System.EventArgs e)
		{
			backCounter = 0;

			if (True_RBTN.Checked || False_RBTN.Checked)
			{
				bool userAnswer = true ? True_RBTN.Checked : False_RBTN.Checked;
				bool correctAnswer = Answers.answers[RowNumber] == "True" ? true : false;

				if (correctAnswer)
				{
					correctAnswers++;
					lastCorrectAnswer = true;
					lastInCorrectAnswer = false;
					CorrectAnswers_LBL.Text = correctAnswers.ToString();
				}
				else
				{
					incAnswers++;
					lastInCorrectAnswer = true;
					lastCorrectAnswer = false;
					InCorrectAnswers_LBL.Text = incAnswers.ToString();
				}
				RowNumber++;

				if (backCounter == 0)
				{
					Back_BTN.Enabled = Enabled;
					Back_BTN.BackColor = System.Drawing.Color.Salmon;
				}
				else
				{
					Back_BTN.Enabled = false;
					Back_BTN.BackColor = System.Drawing.Color.Gray;
				}

				NumberOfQ_LBL.Text = $"Question {RowNumber + 1}:";
				Questions_LBL.Text = Questions.questions[RowNumber];

				if (RowNumber == 9)
				{
					if (correctAnswers > 8 && incAnswers <= 10)
					{
						DialogResult result = MessageBox.Show("Coding Wizard!", "End Of Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else if (correctAnswers > 5 && incAnswers <= 7)
					{
						DialogResult result = MessageBox.Show("Solid Coder!", "End Of Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						DialogResult result = MessageBox.Show("Keep practicing!", "End Of Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}

					DialogResult result2 = MessageBox.Show("Do you want to play again?", "End Of Game", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
					if (result2 == DialogResult.Yes)
					{
						RowNumber = 0;
						correctAnswers = 0;
						incAnswers = 0;

						CorrectAnswers_LBL.Text = correctAnswers.ToString();
						InCorrectAnswers_LBL.Text = incAnswers.ToString();

						Back_BTN.Enabled = false;
						Back_BTN.BackColor = System.Drawing.Color.Gray;

						Questions_LBL.Text = Questions.questions[RowNumber];
						NumberOfQ_LBL.Text = $"Question {RowNumber + 1}:";
					}
					else
					{
						this.Close();
					}
				}
				True_RBTN.Checked = false;
				False_RBTN.Checked = false;
			}
			else
			{
				DialogResult result = MessageBox.Show("Please Select Your Answer First!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			}
		}

		private void Back_BTN_Click(object sender, System.EventArgs e)
		{
			if (RowNumber > 0)
			{
				if (backCounter == 0)
				{
					RowNumber--;

					Questions_LBL.Text = Questions.questions[RowNumber];
					NumberOfQ_LBL.Text = $"Question {RowNumber + 1}:";
					True_RBTN.Checked = false;
					False_RBTN.Checked = false;

					if (lastCorrectAnswer)
					{
						correctAnswers--;
						CorrectAnswers_LBL.Text = correctAnswers.ToString();
					}
					else
					{
						incAnswers--;
						InCorrectAnswers_LBL.Text = incAnswers.ToString();
					}

					backCounter++;
				}
				else
				{
					Back_BTN.Enabled = false;
					Back_BTN.BackColor = System.Drawing.Color.Gray;
					DialogResult result = MessageBox.Show("You Can Undo Answer Just Once", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
		}
	}
}
