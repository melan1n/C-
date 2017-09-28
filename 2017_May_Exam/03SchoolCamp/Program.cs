using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03SchoolCamp
{
	class Program
	{
		static void Main(string[] args)
		{
			var season = Console.ReadLine();
			var grouptype = Console.ReadLine();
			var students = int.Parse(Console.ReadLine());
			var nights = int.Parse(Console.ReadLine());

			double pricepernight = 0.00;
			//“Winter”, “Spring” или “Summer”;“boys”, “girls” или “mixed”;
			if ((season == "Winter" && grouptype == "boys")|| (season == "Winter" && grouptype == "girls"))
			{
				pricepernight = 9.60;
			}
			else if (season == "Winter" && grouptype == "mixed")
			{
				pricepernight = 10.00;
			}
			else if ((season == "Spring" && grouptype == "boys") || (season == "Spring" && grouptype == "girls"))
			{
				pricepernight = 7.20;
			}
			else if (season == "Spring" && grouptype == "mixed")
			{
				pricepernight = 9.50;
			}
			else if ((season == "Summer" && grouptype == "boys") || (season == "Summer" && grouptype == "girls"))
			{
				pricepernight = 15;
			}
			else if (season == "Summer" && grouptype == "mixed")
			{
				pricepernight = 20;
			}
			var price = (decimal)(pricepernight * nights*students);
			//if students >= 50 - 50% discount
			if (students>=50)
			{
				price = price / 2;
			}
			else if (students >= 20 && students < 50)
			{
				price = price *85/100;
			}
			else if (students >= 10 && students < 20)
			{
				price = price * 95 / 100;
			}
			//if 20 <= students < 50 - 15 % discount
			//if 10 <= students < 20 - 5 % discount
			var sport = "";
			if (season == "Winter" && grouptype == "girls")
			{
				sport = "Gymnastics";
			}
			else if (season == "Winter" && grouptype == "boys")
			{
				sport = "Judo";
			}
			else if (season == "Winter" && grouptype == "mixed")
			{
				sport = "Ski";
			}
			else if (season == "Spring" && grouptype == "girls")
			{
				sport = "Athletics";
			}
			else if (season == "Spring" && grouptype == "boys")
			{
				sport = "Tennis";
			}
			else if (season == "Spring" && grouptype == "mixed")
			{
				sport = "Cycling";
			}
			else if (season == "Summer" && grouptype == "girls")
			{
				sport = "Volleyball";
			}
			else if (season == "Summer" && grouptype == "boys")
			{
				sport = "Football";
			}
			else if (season == "Summer" && grouptype == "mixed")
			{
				sport = "Swimming";
			}
			

			
			Console.WriteLine("{0} {1:f2} lv.", sport, price);
		}
	}
}
