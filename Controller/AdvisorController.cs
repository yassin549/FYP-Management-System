using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Controller
{
	internal static class AdvisorController
	{
		public static int addAdvisor(SqlConnection con, string salary, int designation)
		{
			int id = PersonController.getLastPersonId();
			SqlCommand AdvisorCmd = new SqlCommand("INSERT INTO Advisor (Id,Designation,Salary)" +
														" VALUES (@Id, @Designation, @Salary)", con);
			AdvisorCmd.Parameters.AddWithValue("@Id", id);
			AdvisorCmd.Parameters.AddWithValue("@Salary", salary);
			AdvisorCmd.Parameters.AddWithValue("@Designation", designation);
			AdvisorCmd.ExecuteNonQuery();
			return id;
		}

		public static bool inAdvisorTable(string id)
		{
			if (DbController.getUserIdFromColumn("Advisor", "Id", id) != null)
			{
				return true;
			}
			return false;
		}
	}
}
