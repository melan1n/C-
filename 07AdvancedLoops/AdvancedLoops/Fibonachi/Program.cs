using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonachi
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			if (n < 2)
			{
				Console.WriteLine("1");
			}
			else
			{
				var f0 = 1;         //first num
				var f1 = 1;         //second num
				var fibonachisum = 2;

				
				for (int i = 1; i <= n / 2; i++)
					{

						fibonachisum = f0 + f1; //sum of first two
						f0 = fibonachisum;          //third num
						f1 = f1 + fibonachisum;     //fourth num
					}

				if (n % 2 == 0)
				{
					Console.WriteLine($"{fibonachisum}");
				}
				else
				{
					Console.WriteLine($"{f1}");
				}
			}
		}
	}
}
