namespace WindowsFormsApp1.Forms.Student
{
	partial class StudentDashboard
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			this.StudentTabs = new Guna.UI2.WinForms.Guna2TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.GroupsDGV = new Guna.UI2.WinForms.Guna2DataGridView();
			this.MakeGroupBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.ProjectsCB = new Guna.UI2.WinForms.Guna2ComboBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.JoinGroupDGV = new Guna.UI2.WinForms.Guna2DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.GroupsCB = new Guna.UI2.WinForms.Guna2ComboBox();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.EmailLbl = new System.Windows.Forms.Label();
			this.GroupLbl = new System.Windows.Forms.Label();
			this.NameLbl = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.StudentTabs.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.GroupsDGV)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.JoinGroupDGV)).BeginInit();
			this.tabPage3.SuspendLayout();
			this.SuspendLayout();
			// 
			// StudentTabs
			// 
			this.StudentTabs.Alignment = System.Windows.Forms.TabAlignment.Left;
			this.StudentTabs.Controls.Add(this.tabPage1);
			this.StudentTabs.Controls.Add(this.tabPage2);
			this.StudentTabs.Controls.Add(this.tabPage3);
			this.StudentTabs.Dock = System.Windows.Forms.DockStyle.Fill;
			this.StudentTabs.ItemSize = new System.Drawing.Size(180, 40);
			this.StudentTabs.Location = new System.Drawing.Point(0, 0);
			this.StudentTabs.Name = "StudentTabs";
			this.StudentTabs.SelectedIndex = 0;
			this.StudentTabs.Size = new System.Drawing.Size(1178, 744);
			this.StudentTabs.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
			this.StudentTabs.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
			this.StudentTabs.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
			this.StudentTabs.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
			this.StudentTabs.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
			this.StudentTabs.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
			this.StudentTabs.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
			this.StudentTabs.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
			this.StudentTabs.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
			this.StudentTabs.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
			this.StudentTabs.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
			this.StudentTabs.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
			this.StudentTabs.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
			this.StudentTabs.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
			this.StudentTabs.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
			this.StudentTabs.TabButtonSize = new System.Drawing.Size(180, 40);
			this.StudentTabs.TabIndex = 0;
			this.StudentTabs.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
			// 
			// tabPage1
			// 
			this.tabPage1.BackColor = System.Drawing.Color.Honeydew;
			this.tabPage1.Controls.Add(this.GroupsDGV);
			this.tabPage1.Controls.Add(this.MakeGroupBtn);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.ProjectsCB);
			this.tabPage1.Location = new System.Drawing.Point(184, 4);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(990, 736);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "tabPage1";
			// 
			// GroupsDGV
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
			this.GroupsDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.GroupsDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.GroupsDGV.ColumnHeadersHeight = 4;
			this.GroupsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.Color.SeaGreen;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.GroupsDGV.DefaultCellStyle = dataGridViewCellStyle3;
			this.GroupsDGV.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.GroupsDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.GroupsDGV.Location = new System.Drawing.Point(3, 360);
			this.GroupsDGV.Name = "GroupsDGV";
			this.GroupsDGV.RowHeadersVisible = false;
			this.GroupsDGV.RowHeadersWidth = 62;
			this.GroupsDGV.RowTemplate.Height = 28;
			this.GroupsDGV.Size = new System.Drawing.Size(984, 373);
			this.GroupsDGV.TabIndex = 3;
			this.GroupsDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.GroupsDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.GroupsDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.GroupsDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.GroupsDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.GroupsDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.GroupsDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.GroupsDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.GroupsDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.GroupsDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GroupsDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.GroupsDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.GroupsDGV.ThemeStyle.HeaderStyle.Height = 4;
			this.GroupsDGV.ThemeStyle.ReadOnly = false;
			this.GroupsDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.GroupsDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.GroupsDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GroupsDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.SeaGreen;
			this.GroupsDGV.ThemeStyle.RowsStyle.Height = 28;
			this.GroupsDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.GroupsDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// MakeGroupBtn
			// 
			this.MakeGroupBtn.BackColor = System.Drawing.Color.SeaGreen;
			this.MakeGroupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.MakeGroupBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.MakeGroupBtn.ForeColor = System.Drawing.Color.Honeydew;
			this.MakeGroupBtn.Location = new System.Drawing.Point(592, 124);
			this.MakeGroupBtn.Name = "MakeGroupBtn";
			this.MakeGroupBtn.Size = new System.Drawing.Size(193, 61);
			this.MakeGroupBtn.TabIndex = 2;
			this.MakeGroupBtn.Text = "Make Group";
			this.MakeGroupBtn.UseVisualStyleBackColor = false;
			this.MakeGroupBtn.Click += new System.EventHandler(this.MakeGroupBtn_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(182, 93);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(177, 29);
			this.label1.TabIndex = 1;
			this.label1.Text = "Select Project";
			// 
			// ProjectsCB
			// 
			this.ProjectsCB.BackColor = System.Drawing.Color.Transparent;
			this.ProjectsCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.ProjectsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.ProjectsCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.ProjectsCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.ProjectsCB.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.ProjectsCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.ProjectsCB.ItemHeight = 30;
			this.ProjectsCB.Location = new System.Drawing.Point(107, 137);
			this.ProjectsCB.Name = "ProjectsCB";
			this.ProjectsCB.Size = new System.Drawing.Size(340, 36);
			this.ProjectsCB.TabIndex = 0;
			// 
			// tabPage2
			// 
			this.tabPage2.BackColor = System.Drawing.Color.Honeydew;
			this.tabPage2.Controls.Add(this.JoinGroupDGV);
			this.tabPage2.Controls.Add(this.button1);
			this.tabPage2.Controls.Add(this.label2);
			this.tabPage2.Controls.Add(this.GroupsCB);
			this.tabPage2.Location = new System.Drawing.Point(184, 4);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(990, 736);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			// 
			// JoinGroupDGV
			// 
			dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
			this.JoinGroupDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
			dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.JoinGroupDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
			this.JoinGroupDGV.ColumnHeadersHeight = 4;
			this.JoinGroupDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.Color.SeaGreen;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.JoinGroupDGV.DefaultCellStyle = dataGridViewCellStyle6;
			this.JoinGroupDGV.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.JoinGroupDGV.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.JoinGroupDGV.Location = new System.Drawing.Point(3, 385);
			this.JoinGroupDGV.Name = "JoinGroupDGV";
			this.JoinGroupDGV.RowHeadersVisible = false;
			this.JoinGroupDGV.RowHeadersWidth = 62;
			this.JoinGroupDGV.RowTemplate.Height = 28;
			this.JoinGroupDGV.Size = new System.Drawing.Size(984, 348);
			this.JoinGroupDGV.TabIndex = 3;
			this.JoinGroupDGV.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
			this.JoinGroupDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
			this.JoinGroupDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
			this.JoinGroupDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
			this.JoinGroupDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
			this.JoinGroupDGV.ThemeStyle.BackColor = System.Drawing.Color.White;
			this.JoinGroupDGV.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.JoinGroupDGV.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.JoinGroupDGV.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.JoinGroupDGV.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.JoinGroupDGV.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
			this.JoinGroupDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
			this.JoinGroupDGV.ThemeStyle.HeaderStyle.Height = 4;
			this.JoinGroupDGV.ThemeStyle.ReadOnly = false;
			this.JoinGroupDGV.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
			this.JoinGroupDGV.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.JoinGroupDGV.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.JoinGroupDGV.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.SeaGreen;
			this.JoinGroupDGV.ThemeStyle.RowsStyle.Height = 28;
			this.JoinGroupDGV.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
			this.JoinGroupDGV.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.SeaGreen;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.Honeydew;
			this.button1.Location = new System.Drawing.Point(608, 101);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(153, 67);
			this.button1.TabIndex = 2;
			this.button1.Text = "Join";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(238, 77);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(98, 29);
			this.label2.TabIndex = 1;
			this.label2.Text = "Groups";
			// 
			// GroupsCB
			// 
			this.GroupsCB.BackColor = System.Drawing.Color.Transparent;
			this.GroupsCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
			this.GroupsCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.GroupsCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.GroupsCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.GroupsCB.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.GroupsCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
			this.GroupsCB.ItemHeight = 30;
			this.GroupsCB.Location = new System.Drawing.Point(125, 119);
			this.GroupsCB.Name = "GroupsCB";
			this.GroupsCB.Size = new System.Drawing.Size(344, 36);
			this.GroupsCB.TabIndex = 0;
			// 
			// tabPage3
			// 
			this.tabPage3.BackColor = System.Drawing.Color.Honeydew;
			this.tabPage3.Controls.Add(this.button2);
			this.tabPage3.Controls.Add(this.EmailLbl);
			this.tabPage3.Controls.Add(this.GroupLbl);
			this.tabPage3.Controls.Add(this.NameLbl);
			this.tabPage3.Controls.Add(this.label6);
			this.tabPage3.Controls.Add(this.label5);
			this.tabPage3.Controls.Add(this.label4);
			this.tabPage3.Controls.Add(this.label3);
			this.tabPage3.Location = new System.Drawing.Point(184, 4);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(990, 736);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "tabPage3";
			// 
			// EmailLbl
			// 
			this.EmailLbl.AutoSize = true;
			this.EmailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.EmailLbl.Location = new System.Drawing.Point(191, 285);
			this.EmailLbl.Name = "EmailLbl";
			this.EmailLbl.Size = new System.Drawing.Size(64, 25);
			this.EmailLbl.TabIndex = 6;
			this.EmailLbl.Text = "label7";
			// 
			// GroupLbl
			// 
			this.GroupLbl.AutoSize = true;
			this.GroupLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.GroupLbl.Location = new System.Drawing.Point(194, 358);
			this.GroupLbl.Name = "GroupLbl";
			this.GroupLbl.Size = new System.Drawing.Size(64, 25);
			this.GroupLbl.TabIndex = 5;
			this.GroupLbl.Text = "label7";
			// 
			// NameLbl
			// 
			this.NameLbl.AutoSize = true;
			this.NameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.NameLbl.Location = new System.Drawing.Point(191, 203);
			this.NameLbl.Name = "NameLbl";
			this.NameLbl.Size = new System.Drawing.Size(64, 25);
			this.NameLbl.TabIndex = 4;
			this.NameLbl.Text = "label7";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(89, 281);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(93, 29);
			this.label6.TabIndex = 3;
			this.label6.Text = "Email: ";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(89, 355);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(99, 29);
			this.label5.TabIndex = 2;
			this.label5.Text = "Group: ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(89, 200);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(96, 29);
			this.label4.TabIndex = 1;
			this.label4.Text = "Name: ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(366, 71);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(223, 46);
			this.label3.TabIndex = 0;
			this.label3.Text = "Profile Info";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.SeaGreen;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.Honeydew;
			this.button2.Location = new System.Drawing.Point(577, 275);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(263, 49);
			this.button2.TabIndex = 7;
			this.button2.Text = "Delete Account";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// StudentDashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Honeydew;
			this.ClientSize = new System.Drawing.Size(1178, 744);
			this.Controls.Add(this.StudentTabs);
			this.ForeColor = System.Drawing.Color.SeaGreen;
			this.MaximizeBox = false;
			this.Name = "StudentDashboard";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Student Dashboard";
			this.Load += new System.EventHandler(this.StudentDashboard_Load);
			this.StudentTabs.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.GroupsDGV)).EndInit();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.JoinGroupDGV)).EndInit();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private Guna.UI2.WinForms.Guna2TabControl StudentTabs;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private Guna.UI2.WinForms.Guna2ComboBox ProjectsCB;
		private System.Windows.Forms.Label label1;
		private Guna.UI2.WinForms.Guna2DataGridView GroupsDGV;
		private System.Windows.Forms.Button MakeGroupBtn;
		private Guna.UI2.WinForms.Guna2DataGridView JoinGroupDGV;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label2;
		private Guna.UI2.WinForms.Guna2ComboBox GroupsCB;
		private System.Windows.Forms.TabPage tabPage3;
		private System.Windows.Forms.Label EmailLbl;
		private System.Windows.Forms.Label GroupLbl;
		private System.Windows.Forms.Label NameLbl;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button button2;
	}
}