namespace TenQuizQuestions
{
	partial class Game_FRM
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game_FRM));
			this.Icon_PIC = new System.Windows.Forms.PictureBox();
			this.Title_PNL = new System.Windows.Forms.Panel();
			this.NumberOfQ_LBL = new System.Windows.Forms.Label();
			this.Questions_LBL = new System.Windows.Forms.Label();
			this.True_RBTN = new System.Windows.Forms.RadioButton();
			this.False_RBTN = new System.Windows.Forms.RadioButton();
			this.panel2 = new System.Windows.Forms.Panel();
			this.InCorrectAnswers_LBL = new System.Windows.Forms.Label();
			this.InCorrectAnswersTitle_LBL = new System.Windows.Forms.Label();
			this.CorrectAnswers_LBL = new System.Windows.Forms.Label();
			this.NumberTrueTitle_LBL = new System.Windows.Forms.Label();
			this.Next_BTN = new System.Windows.Forms.Button();
			this.Back_BTN = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.Icon_PIC)).BeginInit();
			this.Title_PNL.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// Icon_PIC
			// 
			this.Icon_PIC.Image = global::TenQuizQuestions.Properties.Resources.icons8_Ask_Question_68px;
			this.Icon_PIC.Location = new System.Drawing.Point(173, 14);
			this.Icon_PIC.Name = "Icon_PIC";
			this.Icon_PIC.Size = new System.Drawing.Size(67, 65);
			this.Icon_PIC.TabIndex = 0;
			this.Icon_PIC.TabStop = false;
			// 
			// Title_PNL
			// 
			this.Title_PNL.BackColor = System.Drawing.Color.White;
			this.Title_PNL.Controls.Add(this.Icon_PIC);
			this.Title_PNL.Location = new System.Drawing.Point(13, 13);
			this.Title_PNL.Name = "Title_PNL";
			this.Title_PNL.Size = new System.Drawing.Size(417, 94);
			this.Title_PNL.TabIndex = 1;
			// 
			// NumberOfQ_LBL
			// 
			this.NumberOfQ_LBL.AutoSize = true;
			this.NumberOfQ_LBL.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.NumberOfQ_LBL.Location = new System.Drawing.Point(12, 110);
			this.NumberOfQ_LBL.Name = "NumberOfQ_LBL";
			this.NumberOfQ_LBL.Size = new System.Drawing.Size(89, 19);
			this.NumberOfQ_LBL.TabIndex = 2;
			this.NumberOfQ_LBL.Text = "Question 1:";
			// 
			// Questions_LBL
			// 
			this.Questions_LBL.AutoSize = true;
			this.Questions_LBL.BackColor = System.Drawing.Color.White;
			this.Questions_LBL.Location = new System.Drawing.Point(13, 138);
			this.Questions_LBL.Name = "Questions_LBL";
			this.Questions_LBL.Size = new System.Drawing.Size(121, 19);
			this.Questions_LBL.TabIndex = 3;
			this.Questions_LBL.Text = "What Is Coding?!";
			// 
			// True_RBTN
			// 
			this.True_RBTN.AutoSize = true;
			this.True_RBTN.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.True_RBTN.Cursor = System.Windows.Forms.Cursors.Hand;
			this.True_RBTN.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.True_RBTN.Location = new System.Drawing.Point(14, 214);
			this.True_RBTN.Name = "True_RBTN";
			this.True_RBTN.Size = new System.Drawing.Size(59, 23);
			this.True_RBTN.TabIndex = 4;
			this.True_RBTN.TabStop = true;
			this.True_RBTN.Text = "True";
			this.True_RBTN.UseVisualStyleBackColor = false;
			// 
			// False_RBTN
			// 
			this.False_RBTN.AutoSize = true;
			this.False_RBTN.BackColor = System.Drawing.Color.LightSalmon;
			this.False_RBTN.Cursor = System.Windows.Forms.Cursors.Hand;
			this.False_RBTN.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.False_RBTN.Location = new System.Drawing.Point(79, 214);
			this.False_RBTN.Name = "False_RBTN";
			this.False_RBTN.Size = new System.Drawing.Size(62, 23);
			this.False_RBTN.TabIndex = 5;
			this.False_RBTN.TabStop = true;
			this.False_RBTN.Text = "False";
			this.False_RBTN.UseVisualStyleBackColor = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.White;
			this.panel2.Controls.Add(this.InCorrectAnswers_LBL);
			this.panel2.Controls.Add(this.InCorrectAnswersTitle_LBL);
			this.panel2.Controls.Add(this.CorrectAnswers_LBL);
			this.panel2.Controls.Add(this.NumberTrueTitle_LBL);
			this.panel2.Location = new System.Drawing.Point(12, 243);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(418, 71);
			this.panel2.TabIndex = 6;
			// 
			// InCorrectAnswers_LBL
			// 
			this.InCorrectAnswers_LBL.AutoSize = true;
			this.InCorrectAnswers_LBL.Location = new System.Drawing.Point(269, 42);
			this.InCorrectAnswers_LBL.Name = "InCorrectAnswers_LBL";
			this.InCorrectAnswers_LBL.Size = new System.Drawing.Size(17, 19);
			this.InCorrectAnswers_LBL.TabIndex = 3;
			this.InCorrectAnswers_LBL.Text = "0";
			// 
			// InCorrectAnswersTitle_LBL
			// 
			this.InCorrectAnswersTitle_LBL.AutoSize = true;
			this.InCorrectAnswersTitle_LBL.Location = new System.Drawing.Point(133, 42);
			this.InCorrectAnswersTitle_LBL.Name = "InCorrectAnswersTitle_LBL";
			this.InCorrectAnswersTitle_LBL.Size = new System.Drawing.Size(130, 19);
			this.InCorrectAnswersTitle_LBL.TabIndex = 2;
			this.InCorrectAnswersTitle_LBL.Text = "InCorrect Answers:";
			// 
			// CorrectAnswers_LBL
			// 
			this.CorrectAnswers_LBL.AutoSize = true;
			this.CorrectAnswers_LBL.Location = new System.Drawing.Point(269, 14);
			this.CorrectAnswers_LBL.Name = "CorrectAnswers_LBL";
			this.CorrectAnswers_LBL.Size = new System.Drawing.Size(17, 19);
			this.CorrectAnswers_LBL.TabIndex = 1;
			this.CorrectAnswers_LBL.Text = "0";
			// 
			// NumberTrueTitle_LBL
			// 
			this.NumberTrueTitle_LBL.AutoSize = true;
			this.NumberTrueTitle_LBL.Location = new System.Drawing.Point(133, 14);
			this.NumberTrueTitle_LBL.Name = "NumberTrueTitle_LBL";
			this.NumberTrueTitle_LBL.Size = new System.Drawing.Size(118, 19);
			this.NumberTrueTitle_LBL.TabIndex = 0;
			this.NumberTrueTitle_LBL.Text = "Correct Answers:";
			// 
			// Next_BTN
			// 
			this.Next_BTN.BackColor = System.Drawing.Color.CornflowerBlue;
			this.Next_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Next_BTN.Location = new System.Drawing.Point(280, 320);
			this.Next_BTN.Name = "Next_BTN";
			this.Next_BTN.Size = new System.Drawing.Size(136, 31);
			this.Next_BTN.TabIndex = 7;
			this.Next_BTN.Text = "Next >";
			this.Next_BTN.UseVisualStyleBackColor = false;
			this.Next_BTN.Click += new System.EventHandler(this.Next_BTN_Click);
			// 
			// Back_BTN
			// 
			this.Back_BTN.BackColor = System.Drawing.Color.Salmon;
			this.Back_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Back_BTN.Location = new System.Drawing.Point(16, 320);
			this.Back_BTN.Name = "Back_BTN";
			this.Back_BTN.Size = new System.Drawing.Size(125, 31);
			this.Back_BTN.TabIndex = 8;
			this.Back_BTN.Text = "< Back";
			this.Back_BTN.UseVisualStyleBackColor = false;
			this.Back_BTN.Click += new System.EventHandler(this.Back_BTN_Click);
			// 
			// Game_FRM
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(442, 356);
			this.Controls.Add(this.Back_BTN);
			this.Controls.Add(this.Next_BTN);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.False_RBTN);
			this.Controls.Add(this.True_RBTN);
			this.Controls.Add(this.Questions_LBL);
			this.Controls.Add(this.NumberOfQ_LBL);
			this.Controls.Add(this.Title_PNL);
			this.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.Name = "Game_FRM";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Game";
			((System.ComponentModel.ISupportInitialize)(this.Icon_PIC)).EndInit();
			this.Title_PNL.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox Icon_PIC;
		private System.Windows.Forms.Panel Title_PNL;
		private System.Windows.Forms.Label NumberOfQ_LBL;
		private System.Windows.Forms.Label Questions_LBL;
		private System.Windows.Forms.RadioButton True_RBTN;
		private System.Windows.Forms.RadioButton False_RBTN;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label InCorrectAnswers_LBL;
		private System.Windows.Forms.Label InCorrectAnswersTitle_LBL;
		private System.Windows.Forms.Label CorrectAnswers_LBL;
		private System.Windows.Forms.Label NumberTrueTitle_LBL;
		private System.Windows.Forms.Button Next_BTN;
		private System.Windows.Forms.Button Back_BTN;
	}
}