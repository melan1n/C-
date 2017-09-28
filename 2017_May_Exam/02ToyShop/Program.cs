using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02ToyShop
{
	class Program
	{
		static void Main(string[] args)
		{
			var ExcursionPrice = decimal.Parse(Console.ReadLine());
			var puzzleNumber = int.Parse(Console.ReadLine());
			var dollNumber = int.Parse(Console.ReadLine());
			var bearNumber = int.Parse(Console.ReadLine());
			var minionNumber = int.Parse(Console.ReadLine());
			var truckNumber = int.Parse(Console.ReadLine());

			var puzzlePrice = 2.60;
			var dollPrice = 3.00;
			var bearPrice = 4.10;
			var minionPrice = 8.20;
			var truckPrice = 2.00;
						
			var totalPrice = (decimal)(puzzleNumber * puzzlePrice + dollNumber * dollPrice + bearNumber * bearPrice + minionNumber * minionPrice + truckNumber * truckPrice);
			//if volume >= 50 - discount 25% of total
			if (puzzleNumber + dollNumber + bearNumber + minionNumber + truckNumber >= 50)
			{
				totalPrice = totalPrice * 3 / 4;
			}
			//rent = 0.1*profit
			var profit = totalPrice * 9 / 10;
			if (profit>= ExcursionPrice)
			{
				Console.WriteLine("Yes! {0:f2} lv left.", profit - ExcursionPrice);
			}
			else
			{
				Console.WriteLine("Not enough money! {0:f2} lv needed.", ExcursionPrice - profit);

			}

		}
	}
}
