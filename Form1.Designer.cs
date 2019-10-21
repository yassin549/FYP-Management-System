namespace WindowsFormsApp1
{
	partial class StartScreen
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.LoginTB = new System.Windows.Forms.TextBox();
			this.LoginBtn = new System.Windows.Forms.Button();
			this.AdvisorSignInBtn = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(518, 55);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(118, 46);
			this.label1.TabIndex = 0;
			this.label1.Text = "Login";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(290, 201);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(86, 29);
			this.label2.TabIndex = 1;
			this.label2.Text = "Email: ";
			// 
			// LoginTB
			// 
			this.LoginTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LoginTB.Location = new System.Drawing.Point(387, 197);
			this.LoginTB.Name = "LoginTB";
			this.LoginTB.Size = new System.Drawing.Size(454, 35);
			this.LoginTB.TabIndex = 2;
			// 
			// LoginBtn
			// 
			this.LoginBtn.BackColor = System.Drawing.Color.LimeGreen;
			this.LoginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.LoginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LoginBtn.ForeColor = System.Drawing.Color.Honeydew;
			this.LoginBtn.Location = new System.Drawing.Point(502, 257);
			this.LoginBtn.Name = "LoginBtn";
			this.LoginBtn.Size = new System.Drawing.Size(153, 54);
			this.LoginBtn.TabIndex = 3;
			this.LoginBtn.Text = "Login";
			this.LoginBtn.UseVisualStyleBackColor = false;
			this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
			// 
			// AdvisorSignInBtn
			// 
			this.AdvisorSignInBtn.BackColor = System.Drawing.Color.LimeGreen;
			this.AdvisorSignInBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AdvisorSignInBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AdvisorSignInBtn.ForeColor = System.Drawing.Color.Honeydew;
			this.AdvisorSignInBtn.Location = new System.Drawing.Point(452, 593);
			this.AdvisorSignInBtn.Name = "AdvisorSignInBtn";
			this.AdvisorSignInBtn.Size = new System.Drawing.Size(257, 54);
			this.AdvisorSignInBtn.TabIndex = 4;
			this.AdvisorSignInBtn.Text = "Advisor";
			this.AdvisorSignInBtn.UseVisualStyleBackColor = false;
			this.AdvisorSignInBtn.Click += new System.EventHandler(this.AdvisorSignInBtn_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.LimeGreen;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.Honeydew;
			this.button2.Location = new System.Drawing.Point(452, 481);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(257, 54);
			this.button2.TabIndex = 5;
			this.button2.Text = "Student";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(493, 394);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(162, 46);
			this.label3.TabIndex = 6;
			this.label3.Text = "Sign Up";
			// 
			// StartScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Honeydew;
			this.ClientSize = new System.Drawing.Size(1178, 744);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.AdvisorSignInBtn);
			this.Controls.Add(this.LoginBtn);
			this.Controls.Add(this.LoginTB);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "StartScreen";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Login";
			this.Load += new System.EventHandler(this.StartScreen_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox LoginTB;
		private System.Windows.Forms.Button LoginBtn;
		private System.Windows.Forms.Button AdvisorSignInBtn;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label3;
	}
}

