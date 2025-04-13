namespace TenQuizQuestions
{
	partial class Start_FRM
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start_FRM));
			this.GameLogo_PIC = new System.Windows.Forms.PictureBox();
			this.Title_LBL = new System.Windows.Forms.Label();
			this.Start_BTN = new System.Windows.Forms.Button();
			this.GitHub_LBLL = new System.Windows.Forms.LinkLabel();
			this.WebSite_LBLL = new System.Windows.Forms.LinkLabel();
			((System.ComponentModel.ISupportInitialize)(this.GameLogo_PIC)).BeginInit();
			this.SuspendLayout();
			// 
			// GameLogo_PIC
			// 
			this.GameLogo_PIC.Image = global::TenQuizQuestions.Properties.Resources.icons8_laptop_coding_200px;
			this.GameLogo_PIC.Location = new System.Drawing.Point(88, 12);
			this.GameLogo_PIC.Name = "GameLogo_PIC";
			this.GameLogo_PIC.Size = new System.Drawing.Size(198, 168);
			this.GameLogo_PIC.TabIndex = 0;
			this.GameLogo_PIC.TabStop = false;
			// 
			// Title_LBL
			// 
			this.Title_LBL.AutoSize = true;
			this.Title_LBL.Location = new System.Drawing.Point(94, 193);
			this.Title_LBL.Name = "Title_LBL";
			this.Title_LBL.Size = new System.Drawing.Size(190, 20);
			this.Title_LBL.TabIndex = 1;
			this.Title_LBL.Text = "10 Public Coding Questions";
			// 
			// Start_BTN
			// 
			this.Start_BTN.BackColor = System.Drawing.Color.Black;
			this.Start_BTN.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Start_BTN.ForeColor = System.Drawing.Color.White;
			this.Start_BTN.Location = new System.Drawing.Point(98, 219);
			this.Start_BTN.Name = "Start_BTN";
			this.Start_BTN.Size = new System.Drawing.Size(186, 25);
			this.Start_BTN.TabIndex = 2;
			this.Start_BTN.Text = "Start Challenge";
			this.Start_BTN.UseVisualStyleBackColor = false;
			this.Start_BTN.Click += new System.EventHandler(this.Start_BTN_Click);
			// 
			// GitHub_LBLL
			// 
			this.GitHub_LBLL.AutoSize = true;
			this.GitHub_LBLL.Cursor = System.Windows.Forms.Cursors.Hand;
			this.GitHub_LBLL.Location = new System.Drawing.Point(160, 252);
			this.GitHub_LBLL.Name = "GitHub_LBLL";
			this.GitHub_LBLL.Size = new System.Drawing.Size(56, 20);
			this.GitHub_LBLL.TabIndex = 3;
			this.GitHub_LBLL.TabStop = true;
			this.GitHub_LBLL.Text = "GitHub";
			this.GitHub_LBLL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GitHub_LBLL_LinkClicked);
			// 
			// WebSite_LBLL
			// 
			this.WebSite_LBLL.AutoSize = true;
			this.WebSite_LBLL.Cursor = System.Windows.Forms.Cursors.Hand;
			this.WebSite_LBLL.Location = new System.Drawing.Point(156, 278);
			this.WebSite_LBLL.Name = "WebSite_LBLL";
			this.WebSite_LBLL.Size = new System.Drawing.Size(65, 20);
			this.WebSite_LBLL.TabIndex = 4;
			this.WebSite_LBLL.TabStop = true;
			this.WebSite_LBLL.Text = "WebSite";
			this.WebSite_LBLL.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.WebSite_LBLL_LinkClicked);
			// 
			// Start_FRM
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(384, 361);
			this.Controls.Add(this.WebSite_LBLL);
			this.Controls.Add(this.GitHub_LBLL);
			this.Controls.Add(this.Start_BTN);
			this.Controls.Add(this.Title_LBL);
			this.Controls.Add(this.GameLogo_PIC);
			this.Font = new System.Drawing.Font("Microsoft New Tai Lue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.Name = "Start_FRM";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Start";
			((System.ComponentModel.ISupportInitialize)(this.GameLogo_PIC)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox GameLogo_PIC;
		private System.Windows.Forms.Label Title_LBL;
		private System.Windows.Forms.Button Start_BTN;
		private System.Windows.Forms.LinkLabel GitHub_LBLL;
		private System.Windows.Forms.LinkLabel WebSite_LBLL;
	}
}

