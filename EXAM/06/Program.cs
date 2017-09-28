using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06
{
	class Program
	{
		static void Main(string[] args)
		{
			var N = int.Parse(Console.ReadLine());
			var result = "No";

			for (int a = 1; a <= 30; a++)
			{
				for (int b = 1; b <= 30; b++)
				{
					for (int c = 1; c <= 30; c++)
					{
						if (a < b && b < c && a+b+c==N)
						{
							Console.WriteLine("{0} + {1} + {2} = {3}", a, b, c, N);
							result = "Yes";
						}
						else if (a > b && b > c && a*b*c == N)
						{
							Console.WriteLine("{0} * {1} * {2} = {3}", a, b, c, N);
							result = "Yes";
						}
					}
				}
			}
			if (result == "No")
			{
				Console.WriteLine("No!");
			}
			
		}
	}
}
