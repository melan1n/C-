using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
	class Program
	{
		static void Main(string[] args)
		{
			var type = Console.ReadLine();
			var rows = int.Parse(Console.ReadLine());
			var columns = int.Parse(Console.ReadLine());
			var seats = rows * columns;
			var price = 0.00;

			switch (type)
			{
				case "Premiere": price = 12.00; break;
				case "Normal": price = 7.50; break;
				case "Discount": price = 5.00; break;
			}
			
			var result = seats * price;
			Console.WriteLine("{0:f2} leva", result);
		}
	}
}
