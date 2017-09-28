using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1000_Days_After_Birth
{
	class Program
	{
		static void Main(string[] args)
		{
			string birth_date = Console.ReadLine();
			string format = "dd-MM-yyyy";
			DateTime dateTime = DateTime.ParseExact(birth_date, format, CultureInfo.InvariantCulture);
			string dateAdded = dateTime.AddDays(999).ToString(format);

			Console.WriteLine(dateAdded);
		}
	}
}
