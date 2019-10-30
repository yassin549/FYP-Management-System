using CRUD_Operations;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Controller
{
	internal static class PersonController
	{
		public static int getLastPersonId()
		{
			var con = Configuration.getInstance().getConnection();
			SqlCommand cmd = new SqlCommand("SELECT TOP 1 Id FROM Person ORDER BY Id DESC", con); 
			int lastId;

			var result = cmd.ExecuteScalar();
			lastId = result == null ? 1 : (int)result;

			return lastId;
		}

		public static string getCredentials(string credential, string value)
		{
			var con = Configuration.getInstance().getConnection();
			SqlCommand sqlCommand = new SqlCommand("select " + credential + " from Person where id = @column", con);
			sqlCommand.Parameters.AddWithValue("@column", value);
			var x = sqlCommand.ExecuteScalar();
			sqlCommand.ExecuteNonQuery();
			return x == null ? null : x.ToString();
		}
	}
}
