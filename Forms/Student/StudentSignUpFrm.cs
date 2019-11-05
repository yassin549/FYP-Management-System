using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using WindowsFormsApp1.Controller;
using WindowsFormsApp1.Middleware;

namespace WindowsFormsApp1.Forms.Student
{
	public partial class StudentSignUpFrm : Form
	{
		public StudentSignUpFrm()
		{
			InitializeComponent();
		}

		private void StdSignUpBtn_Click(object sender, EventArgs e)
		{
			if (DbController.getFromTable("*", "Person", "where Email = '" + StdEmailTB.Text + "';") == null && Validations.EndsWith(StdEmailTB.Text, "@gmail.com") && StdFirstNameTB.Text != null && StdLastNameTB.Text != null && StdContactTB.Text != null && (StdGenderTB.Text == "1" || StdGenderTB.Text == "2"))
			{
				// insert in database
				string query = " INSERT INTO Person(FirstName, LastName, Contact, Email, DateOfBirth, Gender)" + " VALUES ( '" + StdFirstNameTB.Text + "','" + StdLastNameTB.Text + "' ,'" + StdContactTB.Text + "','" + StdEmailTB.Text + "','" + DateTime.Parse(Date.Text).ToString() + "'," + StdGenderTB.Text + ")";
				int id = StudentController.addStudent(query, DateTime.Parse(Date.Text).Year.ToString());
				// show student main menu form and pass it the id
				StudentDashboard frm = new StudentDashboard(id.ToString());
				frm.ShowDialog();
				this.Hide();
			}
			else
			{
				MessageBox.Show("Validations Error!");
			}
		}

		private void StudentSignUpFrm_Load(object sender, EventArgs e)
		{

		}
	}
}
