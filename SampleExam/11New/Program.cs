using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11New
{
	class Program
	{
		static void Main(string[] args)
		{
			var a = int.Parse(Console.ReadLine());
			var b = int.Parse(Console.ReadLine());

			if (b - a < 3)
			{
				Console.WriteLine("No");
			}
			else
			{
				for (int i = a; i <= b - 3; i++)
				{
					for (int j = i + 1; j <= b - 2; j++)
					{
						for (int k = j + 1; k <= b - 1; k++)
						{
							for (int l = k + 1; l <= b; l++)
							{
								Console.WriteLine("{0} {1} {2} {3}", i, j, k, l);
								
							}
						}
					}
				}
			}
		}
	}
}

