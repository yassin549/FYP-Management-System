using CRUD_Operations;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace WindowsFormsApp1.Controller
{
	internal static class StudentController
	{
		public static bool inStudentTable(string id)
		{
			if (DbController.getUserIdFromColumn("Student","id", id) != null)
			{
				return true;
			}
			return false;
		}

		public static int addStudent(string personQuery, string session)
		{
			DbController.QueryExecuter(personQuery);
			int id = PersonController.getLastPersonId();
			var con = Configuration.getInstance().getConnection();
			SqlCommand studentCmd = new SqlCommand("INSERT INTO Student (ID, RegistrationNo)" + " VALUES (@ID, @RegistrationNo)", con);
			studentCmd.Parameters.AddWithValue("@ID", id);
			studentCmd.Parameters.AddWithValue("@RegistrationNo", session + "-"+ (id + 1) + "-UET");
			studentCmd.ExecuteNonQuery();
			MessageBox.Show("Added!");
			return id;
		}

		
	}
}
