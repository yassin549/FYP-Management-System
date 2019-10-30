using CRUD_Operations;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Security;

namespace WindowsFormsApp1.Controller
{
	internal static class EvaluationsController
	{
		public static string getEvaluationMetric(string name, string column)
		{
			var con = Configuration.getInstance().getConnection();
			SqlCommand Command = new SqlCommand("select " + column + " from Evaluation where Name = @name", con);
			Command.Parameters.AddWithValue("@name", name);
			var y = Command.ExecuteScalar();
			Command.ExecuteNonQuery();
			return y == null ? null : y.ToString();	
		}
	}
}
