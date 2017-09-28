using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var columns = 4 * n + 1;
			var rows = 2 * n + 1;

			Console.WriteLine("{0}", new string('#', columns));

			for (int i = 1; i <= n; i++)
			{
				if (i != n / 2 + 1)
				{
					Console.WriteLine("{0}{1}{2}{3}{2}{1}{0}",
						new string('.', i),
						new string('#', rows - 2 * i),
						new string(' ', i - 1),
						" ");
				}
				else
				{
					Console.WriteLine("{0}{1}{2}{3}{2}{1}{0}",
						new string('.', i),
						new string('#', rows - 2 * i),
						new string(' ', i - 2),
						"(@)");

				}
			}
			for (int j = 0; j < n; j++)
			{
					Console.WriteLine("{0}{1}{0}",
						new string('.', n + 1 +j),
						new string('#', 2 * n -1 - 2*j));
			}

			
		}
	}
}
