using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05Crown
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var rows = n / 2 + 4;
			var columns = 2 * n - 1;

			Console.WriteLine("{0}{1}{2}{1}{0}", "@", new string(' ', (columns - 3) / 2), '@');
			Console.WriteLine("{0}{1}{2}{1}{0}", "**", new string(' ', (columns - 5) / 2), '*');

			for (int i = 0; i < rows - 4; i++)
			{
				if (i < rows - 6)
				{
					Console.WriteLine("{0}{1}{2}{1}{0}",
					("*" + new string('.', i + 1) + "*"),
					(new string(' ', (columns - 6 - 2 * i - 1 - 2 * i - 2) / 2)),
				("*" + new string('.', 2 * i + 1) + "*"));
				}


				else if (i >= rows - 6 && i < rows-5)
				{
					Console.WriteLine("{0}{1}{0}",
						("*" + new string('.', i + 1) + "*"),
						(new string('.', 2 * i + 1)));
				}
				else
				{
					Console.WriteLine("{0}{1}{2}{1}{0}",
					("*" + new string('.', i + 1) + "*"),
					(new string('*', (columns - 4 - 2*i - 2)/2)),
					".");
				}
			}

			//Console.WriteLine(new string('*', columns));
			Console.WriteLine(new string('*', columns));
			Console.WriteLine(new string('*', columns));

		}
	}
}