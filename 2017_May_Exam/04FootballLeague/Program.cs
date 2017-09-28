using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04FootballLeague
{
	class Program
	{
		static void Main(string[] args)
		{
			var capacity = float.Parse(Console.ReadLine());
			var fans = float.Parse(Console.ReadLine());


			var asum = 0.0;
			var bsum = 0.0;
			var vsum = 0.0;
			var gsum = 0.0;

			var sector = Console.ReadLine();

			while (sector != "")
			{
				if (sector == "A")
				{
					asum++; break;
				}
				else if (sector == "B")
				{
					bsum++; break;
				}
				else if (sector == "V")
				{
					vsum++; break;
				}
				else (sector == "G")
				{
					gsum++; break;
				}


				sector = Console.ReadLine();
			}

			Console.WriteLine("{0:f2} %", (float)(asum / fans) * 100);
			Console.WriteLine("{0:f2} %", (float)(bsum / fans) * 100);
			Console.WriteLine("{0:f2} %", (float)(vsum / fans) * 100);
			Console.WriteLine("{0:f2} %", (float)(gsum / fans) * 100);
			Console.WriteLine("{0:f2} %", (float)(fans / capacity) * 100);

		}
	}
}
