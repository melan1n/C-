using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Paralelepiped
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var rows = 4 * n + 4;
			var columns = 3 * n + 1;

			Console.WriteLine("{0}{1}{2}{3}",
				"+", 
				new string('~', n - 2), 
				"+", 
				new string('.', columns - n));

			for (int i = 0; i < 2*n+1; i++)
			{
				Console.WriteLine("{0}{1}{2}{3}{4}{5}",
					"|",
					new string('.', i),
					"\\",
					new string('~', n-2),
					"\\",
					new string('.', (2 * n - i)));

			}
			for (int i = 0; i < 2 * n + 1; i++)
			{
				Console.WriteLine("{0}{1}{2}{3}{4}{5}",
					new string('.', i),
					"\\",
					new string('.', (2 * n - i)),
					"|",
				new string('~', n-2),
					"|");

			}
			Console.WriteLine("{0}{1}{2}{3}",
				new string('.', columns - n),
				"+",
				new string('~', n - 2),
				"+");
		}
	}
}
