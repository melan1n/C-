using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenPosition
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			double OddSum = 0;
			double OddMin = 1000000.0;
			double OddMax = -1000000.0;
			double EvenSum = 0;
			double EvenMin = 1000000.0;
			double EvenMax = -1000000.0;

			for (int i = 1; i <= n; i++)
			{

				double num = double.Parse(Console.ReadLine());
				if (i % 2 == 0)
				{
					EvenSum = EvenSum + num;
				
					if (num > EvenMax)
					{
						EvenMax = num;
					}
					if (num < EvenMin)
					{
						EvenMin = num;
					}
				}
				else
				{
					OddSum = OddSum + num;
				
					if (num > OddMax)
					{
						OddMax = num;
					}
					if (num < OddMin)
					{
						OddMin = num;
					}
				}
			}
			Console.WriteLine($"OddSum={OddSum},");
			if (OddMin == 1000000.0)
			{
				Console.WriteLine($"OddMin=No,");
			}
			else
			{
				Console.WriteLine($"OddMin={OddMin},");
			}
			if (OddMax == -1000000.0)
			{
				Console.WriteLine($"OddMax=No,");
			}
			else
			{
				Console.WriteLine($"OddMax={OddMax},");
			}
			Console.WriteLine("EvenSum={0},", EvenSum);
			if (EvenMin == 1000000.0)
			{
				Console.WriteLine($"EvenMin=No,");
			}
			else
			{
				Console.WriteLine($"EvenMin={EvenMin},");
			}
			if (EvenMax == -1000000.0)
			{
				Console.WriteLine($"EvenMax=No");
			}
			else
			{
				Console.WriteLine($"EvenMax={EvenMax}");
			}

		}
	}
}
