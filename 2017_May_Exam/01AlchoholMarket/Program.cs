using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01AlchoholMarket
{
	class Program
	{
		static void Main(string[] args)
		{
			var whiskyprice = decimal.Parse(Console.ReadLine());
			var beervolume = decimal.Parse(Console.ReadLine());
			var winevolume = decimal.Parse(Console.ReadLine());
			var brandyvolume = decimal.Parse(Console.ReadLine());
			var whiskyvolume = decimal.Parse(Console.ReadLine());

			var brandyprice = whiskyprice / 2;
			var wineprice = brandyprice * 6 / 10; 
			var beerprice = brandyprice / 5;

			var money = whiskyvolume * whiskyprice + beervolume * beerprice + winevolume * wineprice + brandyvolume * brandyprice;
			Console.WriteLine("{0:f2}", money);
		}

	}
}
