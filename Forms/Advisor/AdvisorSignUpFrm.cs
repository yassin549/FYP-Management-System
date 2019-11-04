using CRUD_Operations;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Controller;
using WindowsFormsApp1.Middleware;

namespace WindowsFormsApp1.Forms.Advisor
{
	public partial class AdvisorSignUpFrm : Form
	{
		public AdvisorSignUpFrm()
		{
			InitializeComponent();
			var con = Configuration.getInstance().getConnection();
			SqlCommand cmd = new SqlCommand("Select * from Lookup where Category = 'DESIGNATION';", con);
			SqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				AdvRoleCB.Items.Add(reader.GetString(1));
			}
			reader.Close();
		}

		private void AdvisorSignUpFrm_Load(object sender, EventArgs e)
		{

		}

		private void addInPersonTable(SqlConnection con)
		{
			SqlCommand personCmd = new SqlCommand("INSERT INTO Person (FirstName, LastName, Contact, Email, DateOfBirth, Gender)" +
														" VALUES (@firstName, @lastName, @contact, @email, @dateOfBirth, @gender)", con);
			personCmd.Parameters.AddWithValue("@firstName", AdvFirstNameTB.Text);
			personCmd.Parameters.AddWithValue("@lastName", AdvLastNameTB.Text);
			personCmd.Parameters.AddWithValue("@contact", AdvContactTB.Text);
			personCmd.Parameters.AddWithValue("@email", AdvEmailTB.Text);
			personCmd.Parameters.AddWithValue("@dateofbirth", DateTime.Parse(Date.Text));
			personCmd.Parameters.AddWithValue("@gender", AdvGenderTB.Text);
			personCmd.ExecuteNonQuery();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (Validations.EndsWith(AdvEmailTB.Text, "@gmail.com") && DbController.getFromTable("*", "Person", "where Email = '" + AdvEmailTB.Text + "';") == null && AdvFirstNameTB.Text != null && AdvLastNameTB.Text != null && AdvContactTB.Text != null && (AdvGenderTB.Text == "1" || AdvGenderTB.Text == "0") && AdvSalaryTB.Text != null && int.TryParse(AdvSalaryTB.Text, out int x) && int.Parse(AdvSalaryTB.Text) > 0)
			{
				var con = Configuration.getInstance().getConnection();

				SqlCommand checker = new SqlCommand("Select id from Lookup where Value = @value", con);
				checker.Parameters.AddWithValue("@value", AdvRoleCB.Text);
				int Id = 0;
				try
				{
					SqlDataReader reader = checker.ExecuteReader();

					if (reader.Read())
					{
						Id = reader.GetInt32(0);
					}
					else
					{
						Id = -1;
					}

					reader.Close();
				}
				catch (SqlException ex)
				{
					MessageBox.Show("Select Designation!");

				}

				addInPersonTable(con);
				int advisorId = AdvisorController.addAdvisor(con, AdvSalaryTB.Text, Id);
				MessageBox.Show("Welcome!");
				
				// show advisor form and pass advisor id to it
				AdvisorDashboard frm = new AdvisorDashboard(advisorId.ToString());
				frm.ShowDialog();
				this.Hide();
			}
			MessageBox.Show("Validations Error!");


		}
	}
}
