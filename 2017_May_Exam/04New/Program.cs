using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04New
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

			//char sector = Console.ReadLine()[0];

			string line;
			while ((line = Console.ReadLine()) != "")
			{
				
				switch (line[0])
				{
					case ('A'): asum++; break;
					case ('B'): bsum++; break;
					case ('V'): vsum++; break;
					case ('G'): gsum++; break;
				}
			}

			Console.Write("{0:f2}%{1}{2:f2}%{1}{3:f2}%{1}{4:f2}%{1}{5:f2}%",
				 (asum / fans) * 100,
				 Environment.NewLine,
				 (bsum / fans) * 100,
				 (vsum / fans) * 100,
				 (gsum / fans) * 100,
				 (fans / capacity) * 100);

		}
	}
}
