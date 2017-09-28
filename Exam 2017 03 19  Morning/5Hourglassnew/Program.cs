using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5Hourglassnew
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var rows = 2 * n + 1;
			var columns = rows;
			for (int i = 0; i <= rows; i++)
			{
				if (i == 0 || i == rows)
				{
					Console.WriteLine(new string('*', rows));
				}
				else if (i == 1)
				{
					Console.WriteLine("{0}{1}{2}{1}{0}",
						".", "*", new string(' ', rows - 4));
				}
				else if (i > 1 && i <= n - 1)
				{
					Console.WriteLine("{0}{1}{2}{3}{2}{1}{0}",
						(new string('.', i)), "*", new string('@', n - i - 1), "@");
				}
				else if (i == n)
				{
					Console.WriteLine("{0}{1}{0}",
						(new string('.', n)), "*");
				}
				else if (i > n && i < rows - 2)
				{
					Console.WriteLine("{0}{1}{2}{3}{2}{1}{0}",
						(new string('.', rows - i - 1)), "*", new string(' ', i - n - 1), "@");
				}
				else if (i == rows - 2)
				{
					Console.WriteLine("{0}{1}{2}{3}{2}{1}{0}",
						".", "*", new string('@', i - n - 1), "@");
				}

			}
		}
	}
}
