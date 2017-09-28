using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12RectanglesGenerator
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var m = int.Parse(Console.ReadLine());

			var x1 = -n;
			var y1 = -n;
			var x2 = n;
			var y2 = n;
			var result = "No";

			for (x1 = -n; x1 < n; x1++)
			{
				for (x2 = x1+1; x2 <= n; x2++)
				{
					for (y1 = -n; y1 < n; y1++)
					{
						for (y2 = y1+1; y2 <= n; y2++)
						{
							var area = (x2 - x1) * (y2 - y1);
							if (area>=m)
							{
								result = "Yes"; 
								Console.WriteLine("({0}, {1}) ({2}, {3}) -> {4}",
									x1, y1, x2, y2, area);
							}
						}
					}
				}
			}
			if (result == "No")
			{
				Console.WriteLine("No");
			}
			
		}
	}
}
