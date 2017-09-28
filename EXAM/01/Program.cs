using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
	class Program
	{
		static void Main(string[] args)
		{
			var days = int.Parse(Console.ReadLine());
			var men = int.Parse(Console.ReadLine());
			var cakes = int.Parse(Console.ReadLine());
			var Waffles = int.Parse(Console.ReadLine());
			var pancakes = int.Parse(Console.ReadLine());

			double money = days * men * (cakes * 45 + (double)(Waffles * 5.80) + (double)(pancakes * 3.20))* 7 / 8;
			Console.WriteLine("{0:f2}", money);
		}
	}
}
