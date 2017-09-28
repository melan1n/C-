using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
	class Program
	{
		static void Main(string[] args)
		{
			var fruit = Console.ReadLine();
			var size = Console.ReadLine();
			var amount = double.Parse(Console.ReadLine());
			double litres = 0; 
			double price = 0.00d;

			
			if (fruit == "Watermelon" && size == "small")
			{
				price = 56;
				litres = 2;
			}
			else if (fruit == "Watermelon" && size == "big")
			{
				price = 28.70;
				litres = 5;
			}
			else if (fruit == "Mango" && size == "small")
			{
				price = 36.66;
				litres = 2;
			}
			else if (fruit == "Mango" && size == "big")
			{
				price = 19.60;
				litres = 5;
			}
			else if (fruit == "Pineapple" && size == "small")
			{
				price = 42.10;
				litres = 2;
			}
			else if (fruit == "Pineapple" && size == "big")
			{
				price = 24.80;
				litres = 5;
			}
			else if (fruit == "Raspberry" && size == "small")
			{
				price = 20;
				litres = 2;
			}
			else if (fruit == "Raspberry" && size == "big")
			{
				price = 15.20;
				litres = 5;
			}

			double money = litres * price * amount;

			if (money>1000)
			{
				money = money * 0.5;
			}
			else if (money >= 400 && money <= 1000)
			{
				money = money * 0.85;
			}

			Console.WriteLine("{0:f2} lv.", money);
			


		}
	}
}
