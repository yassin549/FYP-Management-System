namespace WindowsFormsApp1.Forms.Student
{
	partial class StudentSignUpFrm
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
			this.Date = new Guna.UI2.WinForms.Guna2DateTimePicker();
			this.StdGenderTB = new Guna.UI2.WinForms.Guna2TextBox();
			this.StdContactTB = new Guna.UI2.WinForms.Guna2TextBox();
			this.StdLastNameTB = new Guna.UI2.WinForms.Guna2TextBox();
			this.StdFirstNameTB = new Guna.UI2.WinForms.Guna2TextBox();
			this.StdEmailTB = new Guna.UI2.WinForms.Guna2TextBox();
			this.StdSignUpBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.SeaGreen;
			this.label1.Location = new System.Drawing.Point(501, 73);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(181, 46);
			this.label1.TabIndex = 17;
			this.label1.Text = "Sign Up ";
			// 
			// Date
			// 
			this.Date.BackColor = System.Drawing.Color.Transparent;
			this.Date.Checked = true;
			this.Date.FillColor = System.Drawing.Color.Silver;
			this.Date.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.Date.ForeColor = System.Drawing.Color.SeaGreen;
			this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
			this.Date.Location = new System.Drawing.Point(379, 351);
			this.Date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.Date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.Date.Name = "Date";
			this.Date.Size = new System.Drawing.Size(421, 45);
			this.Date.TabIndex = 11;
			this.Date.Value = new System.DateTime(2024, 3, 3, 0, 16, 42, 5);
			// 
			// StdGenderTB
			// 
			this.StdGenderTB.BorderColor = System.Drawing.Color.LightGray;
			this.StdGenderTB.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.StdGenderTB.DefaultText = "";
			this.StdGenderTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.StdGenderTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.StdGenderTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.StdGenderTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.StdGenderTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.StdGenderTB.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.StdGenderTB.ForeColor = System.Drawing.Color.SeaGreen;
			this.StdGenderTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.StdGenderTB.Location = new System.Drawing.Point(378, 481);
			this.StdGenderTB.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.StdGenderTB.Name = "StdGenderTB";
			this.StdGenderTB.PasswordChar = '\0';
			this.StdGenderTB.PlaceholderForeColor = System.Drawing.Color.SeaGreen;
			this.StdGenderTB.PlaceholderText = "Gender";
			this.StdGenderTB.SelectedText = "";
			this.StdGenderTB.Size = new System.Drawing.Size(421, 54);
			this.StdGenderTB.TabIndex = 16;
			// 
			// StdContactTB
			// 
			this.StdContactTB.BorderColor = System.Drawing.Color.LightGray;
			this.StdContactTB.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.StdContactTB.DefaultText = "";
			this.StdContactTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.StdContactTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.StdContactTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.StdContactTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.StdContactTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.StdContactTB.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.StdContactTB.ForeColor = System.Drawing.Color.SeaGreen;
			this.StdContactTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.StdContactTB.Location = new System.Drawing.Point(378, 413);
			this.StdContactTB.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.StdContactTB.Name = "StdContactTB";
			this.StdContactTB.PasswordChar = '\0';
			this.StdContactTB.PlaceholderForeColor = System.Drawing.Color.SeaGreen;
			this.StdContactTB.PlaceholderText = "Contact";
			this.StdContactTB.SelectedText = "";
			this.StdContactTB.Size = new System.Drawing.Size(421, 54);
			this.StdContactTB.TabIndex = 15;
			// 
			// StdLastNameTB
			// 
			this.StdLastNameTB.BorderColor = System.Drawing.Color.LightGray;
			this.StdLastNameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.StdLastNameTB.DefaultText = "";
			this.StdLastNameTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.StdLastNameTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.StdLastNameTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.StdLastNameTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.StdLastNameTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.StdLastNameTB.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.StdLastNameTB.ForeColor = System.Drawing.Color.SeaGreen;
			this.StdLastNameTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.StdLastNameTB.Location = new System.Drawing.Point(378, 280);
			this.StdLastNameTB.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.StdLastNameTB.Name = "StdLastNameTB";
			this.StdLastNameTB.PasswordChar = '\0';
			this.StdLastNameTB.PlaceholderForeColor = System.Drawing.Color.SeaGreen;
			this.StdLastNameTB.PlaceholderText = "Last Name";
			this.StdLastNameTB.SelectedText = "";
			this.StdLastNameTB.Size = new System.Drawing.Size(421, 54);
			this.StdLastNameTB.TabIndex = 14;
			// 
			// StdFirstNameTB
			// 
			this.StdFirstNameTB.BorderColor = System.Drawing.Color.LightGray;
			this.StdFirstNameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.StdFirstNameTB.DefaultText = "";
			this.StdFirstNameTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.StdFirstNameTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.StdFirstNameTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.StdFirstNameTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.StdFirstNameTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.StdFirstNameTB.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.StdFirstNameTB.ForeColor = System.Drawing.Color.SeaGreen;
			this.StdFirstNameTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.StdFirstNameTB.Location = new System.Drawing.Point(378, 216);
			this.StdFirstNameTB.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.StdFirstNameTB.Name = "StdFirstNameTB";
			this.StdFirstNameTB.PasswordChar = '\0';
			this.StdFirstNameTB.PlaceholderForeColor = System.Drawing.Color.SeaGreen;
			this.StdFirstNameTB.PlaceholderText = "First Name";
			this.StdFirstNameTB.SelectedText = "";
			this.StdFirstNameTB.Size = new System.Drawing.Size(421, 54);
			this.StdFirstNameTB.TabIndex = 13;
			// 
			// StdEmailTB
			// 
			this.StdEmailTB.BorderColor = System.Drawing.Color.LightGray;
			this.StdEmailTB.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.StdEmailTB.DefaultText = "";
			this.StdEmailTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.StdEmailTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.StdEmailTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.StdEmailTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.StdEmailTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.StdEmailTB.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.StdEmailTB.ForeColor = System.Drawing.Color.SeaGreen;
			this.StdEmailTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.StdEmailTB.Location = new System.Drawing.Point(378, 147);
			this.StdEmailTB.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.StdEmailTB.Name = "StdEmailTB";
			this.StdEmailTB.PasswordChar = '\0';
			this.StdEmailTB.PlaceholderForeColor = System.Drawing.Color.SeaGreen;
			this.StdEmailTB.PlaceholderText = "Email";
			this.StdEmailTB.SelectedText = "";
			this.StdEmailTB.Size = new System.Drawing.Size(421, 54);
			this.StdEmailTB.TabIndex = 12;
			// 
			// StdSignUpBtn
			// 
			this.StdSignUpBtn.BackColor = System.Drawing.Color.SeaGreen;
			this.StdSignUpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.StdSignUpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.StdSignUpBtn.ForeColor = System.Drawing.Color.Honeydew;
			this.StdSignUpBtn.Location = new System.Drawing.Point(477, 575);
			this.StdSignUpBtn.Name = "StdSignUpBtn";
			this.StdSignUpBtn.Size = new System.Drawing.Size(194, 62);
			this.StdSignUpBtn.TabIndex = 18;
			this.StdSignUpBtn.Text = "Sign Up";
			this.StdSignUpBtn.UseVisualStyleBackColor = false;
			this.StdSignUpBtn.Click += new System.EventHandler(this.StdSignUpBtn_Click);
			// 
			// StudentSignUpFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Honeydew;
			this.ClientSize = new System.Drawing.Size(1178, 744);
			this.Controls.Add(this.StdSignUpBtn);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Date);
			this.Controls.Add(this.StdGenderTB);
			this.Controls.Add(this.StdContactTB);
			this.Controls.Add(this.StdLastNameTB);
			this.Controls.Add(this.StdFirstNameTB);
			this.Controls.Add(this.StdEmailTB);
			this.ForeColor = System.Drawing.Color.SeaGreen;
			this.MaximizeBox = false;
			this.Name = "StudentSignUpFrm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sign Up";
			this.Load += new System.EventHandler(this.StudentSignUpFrm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2DateTimePicker Date;
		private Guna.UI2.WinForms.Guna2TextBox StdGenderTB;
		private Guna.UI2.WinForms.Guna2TextBox StdContactTB;
		private Guna.UI2.WinForms.Guna2TextBox StdLastNameTB;
		private Guna.UI2.WinForms.Guna2TextBox StdFirstNameTB;
		private Guna.UI2.WinForms.Guna2TextBox StdEmailTB;
		private System.Windows.Forms.Button StdSignUpBtn;
	}
}