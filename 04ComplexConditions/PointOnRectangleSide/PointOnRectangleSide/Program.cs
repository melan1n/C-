using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOnRectangleSide
{
	class Program
	{
		static void Main(string[] args)
		{
			var x1 = int.Parse(Console.ReadLine());
			var y1 = int.Parse(Console.ReadLine());
			var x2 = int.Parse(Console.ReadLine());
			var y2 = int.Parse(Console.ReadLine());
			var x = double.Parse(Console.ReadLine());
			var y = double.Parse(Console.ReadLine());

			bool XonSide = (x == x1) || (x == x2);
			bool YonBase = (y == y1) || (y == y2);

			bool Yinside = (y >= y1) && (y <= y2);
			bool Xinside = (x >= x1) && (x <= x2);

			if (XonSide && Yinside || YonBase && Xinside)
			{
				Console.WriteLine("Border");
			}
			else
			{
				Console.WriteLine("Inside / Outside");
			}
		}
	}
}
