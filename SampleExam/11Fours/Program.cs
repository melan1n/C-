using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11Fours
{
	class Program
	{
		static void Main(string[] args)
		{
			var a = int.Parse(Console.ReadLine());
			var b = int.Parse(Console.ReadLine());

			if (b-a <3)
			{
				Console.WriteLine("No");
			}

			else
			{
				var n1 = 0;
				var n2 = 0;
				var n3 = 0;
				var n4 = 0;
				for (int i = a; i <= b - 3; i++)
				{
					n1 = i;
					for (int j = n1+1; j <= b-2; j++)
					{
						n2 = j;

						for (int k = n2+1; k <= b-1 ; k++)
						{
							n3 = k;
							for (int l = n3+1; l <= b; l++)
							{
								n4 = l;
								if (n1 != 0 && n2 != 0 && n3 != 0 && n4 != 0)
								{
									Console.WriteLine("{0} {1} {2} {3}", n1, n2, n3, n4);
								}
								else
								{
									Console.WriteLine("No");
								}
							}
						}
					}
				}
			}
		}
	}
}
