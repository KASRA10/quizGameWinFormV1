using System.Windows.Forms;
using TenQuizQuestions.Models;

namespace TenQuizQuestions
{
	public partial class Game_FRM : Form
	{
		#region PublicItems
		int RowNumber = 0;
		int correctAnswers = 0;
		int incAnswers = 0;
		#endregion
		public Game_FRM()
		{
			InitializeComponent();
			Back_BTN.Enabled = false;
			Back_BTN.BackColor = System.Drawing.Color.Gray;
			Questions_LBL.Text = Questions.qustions[RowNumber];
			True_RBTN.Checked = false;
			False_RBTN.Checked = false;
		}

		private void Next_BTN_Click(object sender, System.EventArgs e)
		{
			if (True_RBTN.Checked || False_RBTN.Checked)
			{
				bool userAnswer = true ? True_RBTN.Checked : False_RBTN.Checked;
				bool correctAnswer = Answers.qustions[RowNumber] == "True" ? true : false;

				if (correctAnswer)
				{
					correctAnswers++;
					CorrectAnswers_LBL.Text = correctAnswers.ToString();
				}
				else
				{
					incAnswers++;
					InCorrectAnswers_LBL.Text = incAnswers.ToString();
				}
				RowNumber++;

				Back_BTN.Enabled = Enabled;
				Back_BTN.BackColor = System.Drawing.Color.Salmon;

				NumberOfQ_LBL.Text = $"Question {RowNumber + 1}:";
				Questions_LBL.Text = Questions.qustions[RowNumber];

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

						Questions_LBL.Text = Questions.qustions[RowNumber];
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
				RowNumber--;

				Questions_LBL.Text = Questions.qustions[RowNumber];
				NumberOfQ_LBL.Text = $"Question {RowNumber + 1}:";
				True_RBTN.Checked = false;
				False_RBTN.Checked = false;
			}

			Back_BTN.Enabled = RowNumber > 0;
			Back_BTN.BackColor = RowNumber > 0 ? System.Drawing.Color.Salmon : System.Drawing.Color.Gray;
		}
	}
}
