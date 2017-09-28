using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5SoftuniLogo
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var rows = 4 * n - 2;
			var columns = 12 * n - 5;

			Console.WriteLine("{0}{1}{0}",
						new string('.', (columns - 1) / 2),
						"#");
			for (int i = 1; i < rows; i++)
			{
				if (i>0 && i<=rows/2-1)
				{
					Console.WriteLine("{0}{1}{2}{1}{0}",
						new string('.', (columns - 1) / 2 - 3 * i),
						new string('#', 3 * i),
						"#");
				}
				else if (i == rows / 2)
				{
					Console.WriteLine(new string('#', columns));
				}
			}
			for (int j = 0; j < (rows-2)/2; j++)
			{
				if (j < n-2)
				{
					Console.WriteLine("{0}{1}{2}{3}{2}{1}{4}",
						"|",
						new string('.', 2 + 3 * j),
						new string('#', (columns - 1) / 2 -3 - 3 * j),
						"#",
						".");
				}
				else if ((j>= n-2) && j <(rows-2)/2-1)
				{
					Console.WriteLine("{0}{1}{2}{3}{2}{1}{4}",
						"|",
						new string('.', (columns-1)/2-3*n-1),
						new string('#', 3*n),
						"#",
						".");
				}
				else
				{
					Console.WriteLine("{0}{1}{2}{3}{2}{1}{4}",
						"@",
						new string('.', (columns - 1) / 2 - 3 * n - 1),
						new string('#', 3 * n),
						"#",
						".");
				}

			}
		}
	}
}
