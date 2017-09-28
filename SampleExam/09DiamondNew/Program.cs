using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09DiamondNew
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var rows = 2 * n - 1;

			for (int i = 1; i <= rows; i++)
			{
				if (i == 1)
				{
					Console.WriteLine("{0}{1}",
						new string(' ', n - i), "*");
				}
				else if (i <= n)
				{
					Console.Write(new string(' ',n-i));
					for (int j = 1; j <= i-1; j++)
					{
						Console.Write("*_");
					}
					Console.Write("*");
					Console.WriteLine();
				}

				else if (i > n-1 && i < rows)
				{
					Console.Write(new string(' ', i - n));

					for (int k = rows - i; k >= 1; k--)
					{
						Console.Write("*_");
					}
					Console.Write("*");
					Console.WriteLine();
				}
				else
				{
					Console.WriteLine("{0}{1}",
						new string(' ', n - 1), "*");
				}


			}

		}
	}
}

