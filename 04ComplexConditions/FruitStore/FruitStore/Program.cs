using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitStore
{
	class Program
	{
		static void Main(string[] args)
		{
			var fruit = Console.ReadLine();
			var day = Console.ReadLine();
			var quantity = double.Parse(Console.ReadLine());
			double price = 0.00;

			if (fruit == "banana")
			{
				if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
				{
					Console.WriteLine(price = quantity * 2.50);
				}
				else if (day == "Saturday" || day == "Sunday")
				{
					Console.WriteLine(price = quantity * 2.70);
				}
				else
				{
					Console.WriteLine("error");
				}
			}
			else if (fruit == "apple")
			{
				if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
				{
					Console.WriteLine(price = quantity * 1.20);
				}
				else if (day == "Saturday" || day == "Sunday")
				{
					Console.WriteLine(price = quantity * 1.25);
				}
				else
				{
					Console.WriteLine("error");
				}
			}
			else if (fruit == "orange")
			{
				if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
				{
					Console.WriteLine(price = quantity * 0.85);
				}
				else if (day == "Saturday" || day == "Sunday")
				{
					Console.WriteLine(price = quantity * 0.90);
				}
				else
				{
					Console.WriteLine("error");
				}
			}
			else if (fruit == "grapefruit")
			{
				if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
				{
					Console.WriteLine(price = quantity * 1.45);
				}
				else if (day == "Saturday" || day == "Sunday")
				{
					Console.WriteLine(price = quantity * 1.60);
				}
				else
				{
					Console.WriteLine("error");
				}
			}
			else if (fruit == "kiwi")
			{
				if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
				{
					Console.WriteLine(price = quantity * 2.70);
				}
				else if (day == "Saturday" || day == "Sunday")
				{
					Console.WriteLine(price = quantity * 3.00);
				}
				else
				{
					Console.WriteLine("error");
				}
			}
			else if (fruit == "pineapple")
			{
				if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
				{
					Console.WriteLine(price = quantity * 5.50);
				}
				else if (day == "Saturday" || day == "Sunday")
				{
					Console.WriteLine(price = quantity * 5.60);
				}
				else
				{
					Console.WriteLine("error");
				}
			}
			else if (fruit == "grapes")
			{
				if (day == "Monday" || day == "Tuesday" || day == "Wednesday" || day == "Thursday" || day == "Friday")
				{
					Console.WriteLine(price = quantity * 3.85);
				}
				else if (day == "Saturday" || day == "Sunday")
				{
					Console.WriteLine(price = quantity * 4.20);
				}
				else
				{
					Console.WriteLine("error");
				}
			}
			else
			{
				Console.WriteLine("error");
			}
			
			
		}
	}
}
