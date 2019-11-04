namespace WindowsFormsApp1.Forms.Advisor
{
	partial class AdvisorSignUpFrm
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
			this.AdvRoleCB = new Guna.UI2.WinForms.Guna2ComboBox();
			this.AdvSalaryTB = new Guna.UI2.WinForms.Guna2TextBox();
			this.Date = new Guna.UI2.WinForms.Guna2DateTimePicker();
			this.AdvGenderTB = new Guna.UI2.WinForms.Guna2TextBox();
			this.AdvContactTB = new Guna.UI2.WinForms.Guna2TextBox();
			this.AdvLastNameTB = new Guna.UI2.WinForms.Guna2TextBox();
			this.AdvFirstNameTB = new Guna.UI2.WinForms.Guna2TextBox();
			this.AdvEmailTB = new Guna.UI2.WinForms.Guna2TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.SeaGreen;
			this.label1.Location = new System.Drawing.Point(519, 70);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(181, 46);
			this.label1.TabIndex = 23;
			this.label1.Text = "Sign Up ";
			// 
			// AdvRoleCB
			// 
			this.AdvRoleCB.BackColor = System.Drawing.Color.Transparent;
			this.AdvRoleCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.AdvRoleCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.AdvRoleCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.AdvRoleCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.AdvRoleCB.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.AdvRoleCB.ForeColor = System.Drawing.Color.SeaGreen;
			this.AdvRoleCB.ItemHeight = 30;
			this.AdvRoleCB.Location = new System.Drawing.Point(544, 555);
			this.AdvRoleCB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.AdvRoleCB.Name = "AdvRoleCB";
			this.AdvRoleCB.Size = new System.Drawing.Size(258, 36);
			this.AdvRoleCB.TabIndex = 22;
			// 
			// AdvSalaryTB
			// 
			this.AdvSalaryTB.BorderColor = System.Drawing.Color.LightGray;
			this.AdvSalaryTB.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.AdvSalaryTB.DefaultText = "";
			this.AdvSalaryTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.AdvSalaryTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.AdvSalaryTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.AdvSalaryTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.AdvSalaryTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.AdvSalaryTB.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.AdvSalaryTB.ForeColor = System.Drawing.Color.SeaGreen;
			this.AdvSalaryTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.AdvSalaryTB.Location = new System.Drawing.Point(382, 550);
			this.AdvSalaryTB.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.AdvSalaryTB.Name = "AdvSalaryTB";
			this.AdvSalaryTB.PasswordChar = '\0';
			this.AdvSalaryTB.PlaceholderForeColor = System.Drawing.Color.SeaGreen;
			this.AdvSalaryTB.PlaceholderText = "Salary";
			this.AdvSalaryTB.SelectedText = "";
			this.AdvSalaryTB.Size = new System.Drawing.Size(155, 54);
			this.AdvSalaryTB.TabIndex = 21;
			// 
			// Date
			// 
			this.Date.BackColor = System.Drawing.Color.Transparent;
			this.Date.Checked = true;
			this.Date.FillColor = System.Drawing.Color.Silver;
			this.Date.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.Date.ForeColor = System.Drawing.Color.SeaGreen;
			this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Long;
			this.Date.Location = new System.Drawing.Point(383, 356);
			this.Date.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Date.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
			this.Date.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
			this.Date.Name = "Date";
			this.Date.Size = new System.Drawing.Size(421, 45);
			this.Date.TabIndex = 15;
			this.Date.Value = new System.DateTime(2024, 3, 3, 0, 16, 42, 5);
			// 
			// AdvGenderTB
			// 
			this.AdvGenderTB.BorderColor = System.Drawing.Color.LightGray;
			this.AdvGenderTB.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.AdvGenderTB.DefaultText = "";
			this.AdvGenderTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.AdvGenderTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.AdvGenderTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.AdvGenderTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.AdvGenderTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.AdvGenderTB.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.AdvGenderTB.ForeColor = System.Drawing.Color.SeaGreen;
			this.AdvGenderTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.AdvGenderTB.Location = new System.Drawing.Point(382, 486);
			this.AdvGenderTB.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.AdvGenderTB.Name = "AdvGenderTB";
			this.AdvGenderTB.PasswordChar = '\0';
			this.AdvGenderTB.PlaceholderForeColor = System.Drawing.Color.SeaGreen;
			this.AdvGenderTB.PlaceholderText = "Gender";
			this.AdvGenderTB.SelectedText = "";
			this.AdvGenderTB.Size = new System.Drawing.Size(421, 54);
			this.AdvGenderTB.TabIndex = 20;
			// 
			// AdvContactTB
			// 
			this.AdvContactTB.BorderColor = System.Drawing.Color.LightGray;
			this.AdvContactTB.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.AdvContactTB.DefaultText = "";
			this.AdvContactTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.AdvContactTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.AdvContactTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.AdvContactTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.AdvContactTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.AdvContactTB.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.AdvContactTB.ForeColor = System.Drawing.Color.SeaGreen;
			this.AdvContactTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.AdvContactTB.Location = new System.Drawing.Point(382, 418);
			this.AdvContactTB.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.AdvContactTB.Name = "AdvContactTB";
			this.AdvContactTB.PasswordChar = '\0';
			this.AdvContactTB.PlaceholderForeColor = System.Drawing.Color.SeaGreen;
			this.AdvContactTB.PlaceholderText = "Contact";
			this.AdvContactTB.SelectedText = "";
			this.AdvContactTB.Size = new System.Drawing.Size(421, 54);
			this.AdvContactTB.TabIndex = 19;
			// 
			// AdvLastNameTB
			// 
			this.AdvLastNameTB.BorderColor = System.Drawing.Color.LightGray;
			this.AdvLastNameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.AdvLastNameTB.DefaultText = "";
			this.AdvLastNameTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.AdvLastNameTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.AdvLastNameTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.AdvLastNameTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.AdvLastNameTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.AdvLastNameTB.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.AdvLastNameTB.ForeColor = System.Drawing.Color.Black;
			this.AdvLastNameTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.AdvLastNameTB.Location = new System.Drawing.Point(382, 285);
			this.AdvLastNameTB.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.AdvLastNameTB.Name = "AdvLastNameTB";
			this.AdvLastNameTB.PasswordChar = '\0';
			this.AdvLastNameTB.PlaceholderForeColor = System.Drawing.Color.SeaGreen;
			this.AdvLastNameTB.PlaceholderText = "Last Name";
			this.AdvLastNameTB.SelectedText = "";
			this.AdvLastNameTB.Size = new System.Drawing.Size(421, 54);
			this.AdvLastNameTB.TabIndex = 18;
			// 
			// AdvFirstNameTB
			// 
			this.AdvFirstNameTB.BorderColor = System.Drawing.Color.LightGray;
			this.AdvFirstNameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.AdvFirstNameTB.DefaultText = "";
			this.AdvFirstNameTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.AdvFirstNameTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.AdvFirstNameTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.AdvFirstNameTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.AdvFirstNameTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.AdvFirstNameTB.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.AdvFirstNameTB.ForeColor = System.Drawing.Color.Black;
			this.AdvFirstNameTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.AdvFirstNameTB.Location = new System.Drawing.Point(382, 221);
			this.AdvFirstNameTB.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.AdvFirstNameTB.Name = "AdvFirstNameTB";
			this.AdvFirstNameTB.PasswordChar = '\0';
			this.AdvFirstNameTB.PlaceholderForeColor = System.Drawing.Color.SeaGreen;
			this.AdvFirstNameTB.PlaceholderText = "First Name";
			this.AdvFirstNameTB.SelectedText = "";
			this.AdvFirstNameTB.Size = new System.Drawing.Size(421, 54);
			this.AdvFirstNameTB.TabIndex = 17;
			// 
			// AdvEmailTB
			// 
			this.AdvEmailTB.BorderColor = System.Drawing.Color.LightGray;
			this.AdvEmailTB.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.AdvEmailTB.DefaultText = "";
			this.AdvEmailTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.AdvEmailTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.AdvEmailTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.AdvEmailTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.AdvEmailTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.AdvEmailTB.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.AdvEmailTB.ForeColor = System.Drawing.Color.Black;
			this.AdvEmailTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.AdvEmailTB.Location = new System.Drawing.Point(382, 152);
			this.AdvEmailTB.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
			this.AdvEmailTB.Name = "AdvEmailTB";
			this.AdvEmailTB.PasswordChar = '\0';
			this.AdvEmailTB.PlaceholderForeColor = System.Drawing.Color.SeaGreen;
			this.AdvEmailTB.PlaceholderText = "Email";
			this.AdvEmailTB.SelectedText = "";
			this.AdvEmailTB.Size = new System.Drawing.Size(421, 54);
			this.AdvEmailTB.TabIndex = 16;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.SeaGreen;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Honeydew;
			this.button1.Location = new System.Drawing.Point(497, 634);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(171, 46);
			this.button1.TabIndex = 24;
			this.button1.Text = "Sign Up";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// AdvisorSignUpFrm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Honeydew;
			this.ClientSize = new System.Drawing.Size(1178, 744);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.AdvRoleCB);
			this.Controls.Add(this.AdvSalaryTB);
			this.Controls.Add(this.Date);
			this.Controls.Add(this.AdvGenderTB);
			this.Controls.Add(this.AdvContactTB);
			this.Controls.Add(this.AdvLastNameTB);
			this.Controls.Add(this.AdvFirstNameTB);
			this.Controls.Add(this.AdvEmailTB);
			this.ForeColor = System.Drawing.Color.SeaGreen;
			this.MaximizeBox = false;
			this.Name = "AdvisorSignUpFrm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Sign Up";
			this.Load += new System.EventHandler(this.AdvisorSignUpFrm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2ComboBox AdvRoleCB;
		private Guna.UI2.WinForms.Guna2TextBox AdvSalaryTB;
		private Guna.UI2.WinForms.Guna2DateTimePicker Date;
		private Guna.UI2.WinForms.Guna2TextBox AdvGenderTB;
		private Guna.UI2.WinForms.Guna2TextBox AdvContactTB;
		private Guna.UI2.WinForms.Guna2TextBox AdvLastNameTB;
		private Guna.UI2.WinForms.Guna2TextBox AdvFirstNameTB;
		private Guna.UI2.WinForms.Guna2TextBox AdvEmailTB;
		private System.Windows.Forms.Button button1;
	}
}