using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HungryGarfield
{
	class Program
	{
		static void Main(string[] args)
		{
			var moneyavailable = decimal.Parse(Console.ReadLine());
			var rate = decimal.Parse(Console.ReadLine());
			var pizzaPrice = decimal.Parse(Console.ReadLine());
			var lasagnePrice = decimal.Parse(Console.ReadLine());
			var sandwichPrice = decimal.Parse(Console.ReadLine());
			var pizzaQuantity = decimal.Parse(Console.ReadLine());
			var lasagneQuantity = decimal.Parse(Console.ReadLine());
			var sandwichQuantity = decimal.Parse(Console.ReadLine());

			var moneyneeded = (pizzaPrice * pizzaQuantity + lasagnePrice * lasagneQuantity + sandwichPrice * sandwichQuantity) / rate;
			decimal diff = moneyavailable - moneyneeded;

			if (diff < 0)
			{
				//Console.WriteLine("Garfield is hungry. John is a badass. Money needed: ${0}.", Math.Round(Math.Abs(diff), 2));
				Console.WriteLine("Garfield is hungry. John is a badass. Money needed: ${0}.", Math.Abs(diff).ToString("0.00"));
			}
			else
			{
				//Console.WriteLine("Garfield is well fed, John is awesome. Money left: ${0}.", Math.Round(diff, 2));
				Console.WriteLine("Garfield is well fed, John is awesome. Money left: ${0}.", diff.ToString("0.00"));
			}

		}
	}
}
