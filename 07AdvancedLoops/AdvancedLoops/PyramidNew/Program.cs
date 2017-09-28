using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PyramidNew
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var printcount = 0;
			var currentnum = 1;
			while (printcount <= n)
			{
				var row = 1;
				var position = 1;
				while (position <= row)
				{
					if (currentnum <= n)
					{
						Console.Write($"{currentnum} ");
						printcount += 1;
						position += 1;
						currentnum += 1;
					}
					else
					{
						Console.WriteLine();
						row += 1;
						position = 1;
						break;
					}
				}
				
			}
			
		}

	}
}
