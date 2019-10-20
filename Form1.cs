using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controller;
using WindowsFormsApp1.Forms.Advisor;
using WindowsFormsApp1.Forms.Student;
using WindowsFormsApp1.Middleware;

namespace WindowsFormsApp1
{
	public partial class StartScreen : Form
	{
		public StartScreen()
		{
			InitializeComponent();
		}

		private void LoginBtn_Click(object sender, EventArgs e)
		{
			if (check())
			{
				string id = DbController.getUserIdFromColumn("Person", "Email", LoginTB.Text);
				if (id != null)
				{
					if (Authenticator.isStudent(id))
					{
						MessageBox.Show("Hello Student");
						// show student main form
						StudentDashboard frm = new StudentDashboard(id);
						frm.ShowDialog();
						this.Hide();
					}
					else if (Authenticator.isAdvisor(id))
					{
						MessageBox.Show("Hello Advisor");
						// show advisor table
						AdvisorDashboard adv = new AdvisorDashboard(id);
						adv.ShowDialog();
						this.Hide();
					}
					else
					{
						MessageBox.Show("Account Does not exist anymore");
					}
				}
				else
				{
					MessageBox.Show("Account not Found!");
				}
			}
			else
			{
				MessageBox.Show("Invalid Email!");
			}
		}

		// student dashboard  
		//		-> join group (load available groups and then join by id)
		//		-> make group (first select a project and then make group)
		//		-> profile (delete student)
		// Advisor dashboard
		//		-> Add project 
		//		-> join a project with designation
		//		-> delete group
		//		-> evaluation metrics
		//		-> evaluate groups
		//		-> reports

		private bool check()
		{
			if (LoginTB.Text != null && Validations.EndsWith<String>(LoginTB.Text, "@gmail.com"))
			{
				return true;
			}
			return false;
		}

		// student sign in btn
		private void button2_Click(object sender, EventArgs e)
		{
			// show student sign in form
			StudentSignUpFrm frm = new StudentSignUpFrm();
			frm.ShowDialog();
			this.Hide();
		}

		private void AdvisorSignInBtn_Click(object sender, EventArgs e)
		{
			// show advisor sign in form
			AdvisorSignUpFrm frm = new AdvisorSignUpFrm();
			frm.ShowDialog();
			this.Hide();
		}

		private void StartScreen_Load(object sender, EventArgs e)
		{

		}
	}
}
