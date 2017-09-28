using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03TruckDriver
{
	class Program
	{
		static void Main(string[] args)
		{
			var season = Console.ReadLine();
			var kmpermonth = double.Parse(Console.ReadLine());
			var rateperkm = 0.00;

			if ((season == "Spring" || season == "Autumn") && kmpermonth <= 5000)
			{
				rateperkm = 0.75;
			}
			else if ((season == "Spring" || season == "Autumn") && (kmpermonth <= 10000 && kmpermonth > 5000))
			{
				rateperkm = 0.95;
			}
			else if (season == "Summer" && kmpermonth <= 5000)
			{
				rateperkm = 0.90;
			}
			else if (season == "Summer" && (kmpermonth <= 10000 && kmpermonth > 5000))
			{
				rateperkm = 1.10;
			}
			else if (season == "Winter" && kmpermonth <= 5000)
			{
				rateperkm = 1.05;
			}
			else if(season == "Winter" && (kmpermonth <= 10000 && kmpermonth > 5000))
			{
				rateperkm = 1.25;
			}
			else if((season == "Spring" || season == "Autumn" || season == "Winter"|| season == "Summer") && (kmpermonth <= 20000 && kmpermonth >= 10000))
			{
				rateperkm = 1.45;
			}
			
			var money = (decimal) kmpermonth * (decimal) rateperkm * 4 * 9 / 10;
			Console.WriteLine("{0:f2}", money);
		}
	}
}
