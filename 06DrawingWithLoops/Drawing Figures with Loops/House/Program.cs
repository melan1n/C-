using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
				

			for (int i = 1; i <= (n+1)/2; i++)
			{
				if (n % 2 == 0 && i == 1)
				{
					Console.WriteLine(new string('-', (n - 2) / 2) + "**" + new string('-', (n - 2) / 2));
				}
				else if (n % 2 == 1 && i == 1)
				{
					Console.WriteLine(new string('-', (n - 1)/2) + "*" + new string('-', (n - 1) / 2));

				}
				else if (i>1 && i < (n + 1) / 2)
				{
					Console.WriteLine(new string('-', (n + 1) / 2 - i) + new string('*', (n - 2 * ((n + 1) / 2 - i))) + new string('-', (n + 1) / 2 - i));
					
				}
				else
				{
					Console.WriteLine(new string('*', n));
				}
			}
			for (int j = 0; j <= n/2 -1; j++)
			{
				Console.WriteLine("|" + new string('*', (n - 2)) + "|");

			}
		}
	}
}
