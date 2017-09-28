using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02StoryFoam
{
	class Program
	{
		static void Main(string[] args)
		{
			var budget = decimal.Parse(Console.ReadLine());
			var area = decimal.Parse(Console.ReadLine());
			var windows = decimal.Parse(Console.ReadLine());
			var metersinunit = decimal.Parse(Console.ReadLine());
			var unitprice = decimal.Parse(Console.ReadLine());

			var money = Math.Ceiling(((area - windows * 24 / 10) * 11 / 10) / metersinunit) * unitprice;

			if (money<=budget)
			{
				Console.WriteLine("Spent: {0:f2}", money);
				Console.WriteLine("Left: {0:f2}", budget - money);
			}
			else
			{
				Console.WriteLine("Need more: {0:f2}", money - budget);

			}
		}
	}
}
