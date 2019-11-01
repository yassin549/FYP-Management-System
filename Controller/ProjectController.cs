using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Controller
{
	internal static class ProjectController
	{
		public static bool alreadyExists(string title)
		{
			if (DbController.getFromTable("Id", "Project", "where Title = '" + title + "';") == null)
			{
				return false;
			}
			return true;
		}

		public static int getProjectIdFromTitle(string title)
		{
			string id =  DbController.getFromTable("Id", "Project", "where Title = '" + title + "'");
			return id == null ? -1 : int.Parse(id);
		}
	}
}
