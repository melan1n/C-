using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			for (int i = 1; i <= n; i++)
			{
				if (i == 1 || i == n)
				{
					Console.WriteLine(new string('*', 2 * n) + new string(' ', n) + new string('*', 2 * n));
				}
				else if (n % 2 == 0 && i == n / 2)
				{
					Console.WriteLine('*' + new string('/', 2 * n - 2) + '*' + new string('|', n) + '*' + new string('/', 2 * n - 2) + '*');
				}
				else if (n % 2 == 1 && i == (n - 1)/ 2 + 1)
				{
					Console.WriteLine('*' + new string('/', 2 * n - 2) + '*' + new string('|', n) + '*' + new string('/', 2 * n - 2) + '*');
				}
				else
				{
					Console.WriteLine('*' + new string('/', 2 * n - 2) + '*' + new string(' ', n) + '*' + new string('/', 2 * n - 2) + '*');
				}
				
			}
		}
	}
}
