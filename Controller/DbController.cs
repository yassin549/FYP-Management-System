using CRUD_Operations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WindowsFormsApp1.Controller
{
	internal static class DbController
	{
		public static string getFromTable(string columns, string table, string query)
		{
			var connection = Configuration.getInstance().getConnection();
			SqlCommand sqlCommand = new SqlCommand("Select " + columns + " from " + table + " " + query, connection);

			var x = sqlCommand.ExecuteScalar();
			sqlCommand.ExecuteNonQuery();
			return x == null ? null : x.ToString();
		}

		public static void QueryExecuter(string query)
		{
			var connection = Configuration.getInstance().getConnection();

			SqlCommand sqlCommand = new SqlCommand(query, connection);
			sqlCommand.ExecuteNonQuery();

		}


		public static string getUserIdFromColumn(string table, string column, string value)
		{
			var con = Configuration.getInstance().getConnection();
			SqlCommand sqlCommand = new SqlCommand("select id from "+ table +" where " + column + " = @column", con);
			sqlCommand.Parameters.AddWithValue("@column", value);
			var x = sqlCommand.ExecuteScalar();
			sqlCommand.ExecuteNonQuery();
			return x == null ? null : x.ToString();

		}

		public static int getLastId(string table)
		{
			var con = Configuration.getInstance().getConnection();
			SqlCommand cmd = new SqlCommand("SELECT TOP 1 Id FROM "+table+" ORDER BY Id DESC", con);
			int lastId;

			var result = cmd.ExecuteScalar();
			lastId = result == null ? 1 : (int)result;

			return lastId;
		}
	}
}
