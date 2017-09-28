using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04PointInsideAFigure
{
	class Program
	{
		static void Main(string[] args)
		{
			var x = int.Parse(Console.ReadLine());
			var y = int.Parse(Console.ReadLine());

			var x1big = 4;
			var y1big = -5;
			var x2big = 10;
			var y2big = 3;
			var x1left = 2;
			var y1left = -3;
			var x2left = 4;
			var y2left = 1;
			var x1right = 10;
			var y1right = -3;
			var x2right = 12;
			var y2right = 1;

			//If inside big or any two small - in. Else Out
			if (((x>=x1big && x<= x2big) && (y>= y1big && y <= y2big)) ||
				((x >= x1right && x <= x2right) && (y >= y1right && y <= y2right)) ||
				((x >= x1left && x <= x2left) && (y >= y1left && y <= y2left)))

			{
				Console.WriteLine("in");

			}
			else
			{
				Console.WriteLine("out");

			}

		}
	}
}
