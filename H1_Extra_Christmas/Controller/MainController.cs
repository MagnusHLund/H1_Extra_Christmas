using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using H1_Extra_Christmas.View;

namespace H1_Extra_Christmas.Controller
{
	internal class MainController
	{
		/// <summary>
		/// This is the entry point for the class.
		/// It gets called from the Program.Main() method.
		/// This method calls the Calculate() method, which takes care of the calculations between today and christmas eve.
		/// </summary>
		internal void Start()
		{
			Calculate();
		}

		/// <summary>
		/// This methos calculates the days between today and christmas eve.
		/// First we define the values for today and christmas.
		/// Then we check if the current year already has had christmas, if it has then we add a year to the christmas date.
		/// Then we calculate the days between christmas and today, using subtraction and then outputs that as a string, to the console.
		/// </summary>
		internal void Calculate()
		{
			DateTime today = DateTime.Now;
			DateTimeOffset christmas = new DateTime(today.Year, 12, 24);

			MainView view = new MainView();

			if (today > christmas)
			{
				christmas.AddYears(1);
			}

			view.Message((christmas - today).TotalDays.ToString());
		}
	}
}
