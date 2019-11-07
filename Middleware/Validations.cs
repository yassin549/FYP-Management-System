using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Middleware
{
	internal static class Validations
	{
		public static bool EndsWith<T>(this T text, string suffix)
		{
			if (text == null || suffix == null)
			{
				return false;
			}

			return text.ToString().ToLower().EndsWith(suffix.ToLower());
		}

		public static int validIntFromCB(ComboBox comboBox)
		{
			if (comboBox.Text == String.Empty)
			{
				return -1;
			}
			return int.Parse(comboBox.Text);
		}
	}
}
