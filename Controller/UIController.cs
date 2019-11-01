using CRUD_Operations;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.Security;
using Guna.UI2.WinForms;

namespace WindowsFormsApp1.Controller
{
	internal static class UIController
	{
		public static void loadGrid(string query, DataGridView dataGrid)
		{
			var con = Configuration.getInstance().getConnection();

			SqlCommand cmd = new SqlCommand(query, con);
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);
			dataGrid.DataSource = dt;

		}

		public static void initializeComboBox(string query, ComboBox box)
		{
			var con = Configuration.getInstance().getConnection(); 
			SqlCommand cmd = new SqlCommand(query, con);
			SqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				box.Items.Add(reader.GetString(0));
			}
			reader.Close();
		}

		public static void initializeComboBox(string query, ComboBox box, bool isInt)
		{
			var con = Configuration.getInstance().getConnection();
			SqlCommand cmd = new SqlCommand(query, con);
			SqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				box.Items.Add(reader.GetInt32(0));
			}
			reader.Close();
		}

		public static void reportsGrid(Guna2DataGridView grid, string query)
		{
			grid.ReadOnly = true;
			var con = Configuration.getInstance().getConnection();
			SqlCommand cmd = new SqlCommand(query, con);
			SqlDataAdapter da = new SqlDataAdapter(cmd);
			DataTable dt = new DataTable();
			da.Fill(dt);
			grid.DataSource = dt;
		}
	}
}
