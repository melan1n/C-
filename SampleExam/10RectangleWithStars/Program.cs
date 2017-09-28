using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10RectangleWithStars
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var columns = 2 * n;
			var rows = 0;

			if (n%2==0)
			{
				rows = n + 1;
			}
			else
			{
				rows = n + 2;
			}
			Console.WriteLine(new string('%', columns));

			for (int i = 0; i < rows-2; i++)
			{
				if (i==(rows-2)/2)
				{
					Console.WriteLine("{0}{1}",
						"%" + new string('.', n - 2) + "*",
						"*" + new string('.', n - 2) + "%");
				}
				else
				{
					Console.WriteLine("{0}{1}{0}",
					"%", new string('.', columns - 2), "%");
				}
			}
			Console.WriteLine(new string('%', columns));

		}
	}
}
