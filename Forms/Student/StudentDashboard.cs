using CRUD_Operations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;
using System.Windows.Forms;
using WindowsFormsApp1.Controller;
using WindowsFormsApp1.Middleware;

namespace WindowsFormsApp1.Forms.Student
{
	public partial class StudentDashboard : Form
	{
		public string id = string.Empty;
		public StudentDashboard(string id)
		{
			InitializeComponent();
			setPanelNames();
			this.id = id;
			setProfile();
			UIController.initializeComboBox("Select Title from Project", ProjectsCB);
			UIController.initializeComboBox("select GroupId from GroupStudent group by GroupId having count(GroupId) < 5;", GroupsCB, true);
			UIController.loadGrid("select * from [Group]", GroupsDGV);
			UIController.loadGrid("select GroupId, count(*) as NumberOfStudents from GroupStudent join [Group] on [Group].Id = GroupId group by GroupId", JoinGroupDGV);
		}

		public void setPanelNames()
		{
			tabPage1.Text = "Make Group";
			tabPage2.Text = "Join Group";
			tabPage3.Text = "Profile";
		}

		public void setProfile()
		{
			NameLbl.Text = PersonController.getCredentials("FirstName + ' ' + LastName", id);
			EmailLbl.Text = PersonController.getCredentials("Email", id);
			string temp = getStudentGroupInfo();
			GroupLbl.Text = temp == null ? "None" : temp;
		}

		public string getStudentGroupInfo()
		{
			var con = Configuration.getInstance().getConnection();
			SqlCommand sqlCommand = new SqlCommand("select * from GroupStudent where StudentId = @column", con);
			sqlCommand.Parameters.AddWithValue("@column", id);
			var x = sqlCommand.ExecuteScalar();
			sqlCommand.ExecuteNonQuery();
			return x == null ? null : x.ToString();
		}


		private void StudentDashboard_Load(object sender, EventArgs e)
		{

		}

		private void MakeGroupBtn_Click(object sender, EventArgs e)
		{
			int projectId = ProjectController.getProjectIdFromTitle(ProjectsCB.Text);
			if (DbController.getFromTable("StudentId", "GroupStudent", "where StudentId = " + id) == null && projectId > 0)
			{
				var con = Configuration.getInstance().getConnection();

				// insert in group table
				SqlCommand s = new SqlCommand("INSERT INTO [Group] (Created_On) VALUES (GETDATE());", con);
				s.ExecuteNonQuery();

				int gId = DbController.getLastId("[Group]");

				// insert in groupProject table
				SqlCommand cm = new SqlCommand("INSERT INTO GroupProject (ProjectId, GroupId, AssignmentDate) VALUES (@ProjectId, @GroupId, @AssignmentDate)", con);
				cm.Parameters.AddWithValue("@ProjectId", projectId);
				cm.Parameters.AddWithValue("@GroupId", gId);
				cm.Parameters.AddWithValue("@AssignmentDate", DateTime.Now);
				cm.ExecuteNonQuery();

				// insert in groupStudent table
				SqlCommand cmd = new SqlCommand("INSERT INTO GroupStudent (GroupId, StudentId, Status, AssignmentDate) VALUES (@GroupId, @StudentId, @Status, @AssignmentDate)", con);
				cmd.Parameters.AddWithValue("@GroupId", gId);
				cmd.Parameters.AddWithValue("@StudentId", id);
				cmd.Parameters.AddWithValue("@Status", 3);
				cmd.Parameters.AddWithValue("@AssignmentDate", DateTime.Now);
				cmd.ExecuteNonQuery();

				MessageBox.Show("Added!");
				UIController.loadGrid("select * from [Group]", GroupsDGV);
				GroupsCB.Items.Clear();
				UIController.initializeComboBox("select GroupId from GroupStudent group by GroupId having count(GroupId) < 5;", GroupsCB, true);
				UIController.loadGrid("select GroupId, count(*) as NumberOfStudents from GroupStudent join [Group] on [Group].Id = GroupId group by GroupId", JoinGroupDGV);

			}
			else
			{
				MessageBox.Show("Already in Group or select a project first!");
			}
		}

		// join group button
		private void button1_Click(object sender, EventArgs e)
		{
			int gId = Validations.validIntFromCB(GroupsCB);
			if (gId > 0 && DbController.getFromTable("*", "GroupStudent", "where StudentId = " + id) == null)
			{
				var con = Configuration.getInstance().getConnection();
				SqlCommand cmd = new SqlCommand("INSERT INTO GroupStudent (GroupId, StudentId, Status, AssignmentDate) VALUES (@GroupId, @StudentId, @Status, @AssignmentDate)", con);
				cmd.Parameters.AddWithValue("@GroupId", gId);
				cmd.Parameters.AddWithValue("@StudentId", id);
				cmd.Parameters.AddWithValue("@Status", 3);
				cmd.Parameters.AddWithValue("@AssignmentDate", DateTime.Now);
				cmd.ExecuteNonQuery();

				MessageBox.Show("Added!");
				UIController.initializeComboBox("select GroupId from GroupStudent group by GroupId having count(GroupId) < 5;", GroupsCB, true);
				UIController.loadGrid("select GroupId, count(*) as NumberOfStudents from GroupStudent join [Group] on [Group].Id = GroupId group by GroupId", JoinGroupDGV);
			}
			else
			{
				MessageBox.Show("Select a group first or already in a group!");
			}
		}

		// delete account
		private void button2_Click(object sender, EventArgs e)
		{
			// changing status from groupstudent table
			if (DbController.getFromTable("*", "GroupStudent", "where StudentId = " + id) != null)
			{
				DbController.QueryExecuter("delete from GroupStudent where StudentId = " + id);
			}
			// removing from student table
			DbController.QueryExecuter("delete from Student where Id = " + id);
			MessageBox.Show("Deleted!");
			StartScreen frm = new StartScreen();
			frm.ShowDialog();
			this.Hide();
		}
	}
}
