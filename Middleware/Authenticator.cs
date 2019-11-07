using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Controller;

namespace WindowsFormsApp1.Middleware
{
	internal static class Authenticator
	{
		public static bool isStudent(string id)
		{
			return StudentController.inStudentTable(id);
		}

		public static bool isAdvisor(string id)
		{
			return AdvisorController.inAdvisorTable(id);
		}
	}
}
