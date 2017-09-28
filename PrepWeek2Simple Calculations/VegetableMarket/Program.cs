using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableMarket
{
	class Program
	{
		static void Main(string[] args)
		{
			var vegetableprice = double.Parse(Console.ReadLine());
			var fruitprice = double.Parse(Console.ReadLine());
			var vegetableamount = int.Parse(Console.ReadLine());
			var fruitamount= int.Parse(Console.ReadLine());

			Console.WriteLine((vegetableprice * vegetableamount + fruitprice * fruitamount) / 1.94);

		}
	}
}
