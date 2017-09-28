using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
	class Program
	{
		static void Main(string[] args)
		{
			var year = Console.ReadLine();
			var holidays = int.Parse(Console.ReadLine());
			var homeweekends = int.Parse(Console.ReadLine());
			var sofiaweekends = 48 - homeweekends;
			var sofiagames = sofiaweekends * 3.0 / 4;
			var holidaygames = holidays * 2.0 / 3;
			var totalgames = homeweekends + sofiagames + holidaygames;
			var factor = 1.00;

			switch (year)
			{
				case "normal": break;
				case "leap": factor = 1.15; break;
			}

			var result = totalgames * factor;
			Console.WriteLine(Math.Truncate(result));


		}
	}
}
