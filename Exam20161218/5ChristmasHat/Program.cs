using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5ChristmasHat
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var rows = 2 * n + 5;
			var columns = 4 * n + 1;

			Console.WriteLine("{0}{1}{0}", new string('.', (columns-3)/2), "/|\\");
			Console.WriteLine("{0}{1}{0}", new string('.', (columns - 3) / 2), "\\|/");

			for (int i = 0; i < 2*n; i++)
			{
				Console.WriteLine("{0}{1}{2}{3}{2}{1}{0}",
					new string('.', 2 * n - 1 - i),
					"*",
					new string('-', i),
					"*");
			}
			for (int j = 1; j <= 3; j++)
			{
				if (j==1 || j==3)
				{
					Console.WriteLine(new string('*', columns));
				}
				else
				{
					for (int k = 0; k < columns/2; k++)
					{
						Console.Write("*");
						Console.Write(".");
					}
					Console.Write("*");
					Console.WriteLine();
				}
			}
		}
	}
}
