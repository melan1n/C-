using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store
{
	class Program
	{
		static void Main(string[] args)
		{
			var product = Console.ReadLine();
			var town = Console.ReadLine();
			var quantity = double.Parse(Console.ReadLine());
			double price = 0.0000;
				
			if (product == "coffee")
			{
				if (town == "Sofia")
				{
					price = quantity * 0.50;
				}
				else if (town == "Plovdiv")
				{
					price = quantity * 0.40;
				}
				else
				{
					price = quantity * 0.45;
				}
			}
			else if (product == "water")
			{
				if (town == "Sofia")
				{
					price = quantity * 0.80;
				}
				else if (town == "Plovdiv")
				{
					price = quantity * 0.70;
				}
				else
				{
					price = quantity * 0.70;
				}
			}
			else if (product == "beer")
			{
				if (town == "Sofia")
				{
					price = quantity * 1.20;
				}
				else if (town == "Plovdiv")
				{
					price = quantity * 1.15;
				}
				else
				{
					price = quantity * 1.10;
				}
			}
			else if (product == "sweets")
			{
				if (town == "Sofia")
				{
					price = quantity * 1.45;
				}
				else if (town == "Plovdiv")
				{
					price = quantity * 1.30;
				}
				else
				{
					price = quantity * 1.35;
				}
			}
			else
			{
				if (town == "Sofia")
				{
					price = quantity * 1.60;
				}
				else if (town == "Plovdiv")
				{
					price = quantity * 1.50;
				}
				else
				{
					price = quantity * 1.55;
				}
			}
			Console.WriteLine(price);
		}
	}
}
