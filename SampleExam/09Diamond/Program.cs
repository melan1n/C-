using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09Diamond
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var rows = 2 * n - 1;

			for (int i = 1; i <= rows; i++)
			{
				if (i == 1 ||i == rows)
				{
					Console.WriteLine("{0}{1}",
						new string(' ', n-i), "*");
				}
				else if (i <= n-1)
				{
					for (int j = 1; j <= i; j++)
					{
						Console.Write(new string(' ', i));
						Console.Write("*_");
					}
					Console.Write("*");
					Console.WriteLine();
				}

				else
				{
					for (int k = n-2; k >= 1; k--)
					{
						Console.Write(new string(' ', i-n));
						Console.Write("*_");
					}
					Console.Write("*");
					Console.WriteLine();

				}


			}

		}
	}
}
