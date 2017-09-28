using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointInFigure
{
	class Program
	{
		static void Main(string[] args)
		{
			var h = int.Parse(Console.ReadLine());
			var x = int.Parse(Console.ReadLine());
			var y = int.Parse(Console.ReadLine());

			//Define recA
			var xA1 = 0;
			var yA1 = 0;
			var xA2 = 3 * h;
			var yA2 = h;

			//Define recB
			var xB1 = h;
			var yB1 = h;
			var xB2 = 2 * h;
			var yB2 = 4 * h;

			bool insiderecA;
			//Point inside/ouside rectangle? below
			if ((x >= xA1) && (x <= xA2) && (y >= yA1) && (y <= yA2))
			{
				insiderecA = true;
			}
			else
			{
				insiderecA = false;
			}

			bool insiderecB;
			//Point inside/ouside rectangle? below
			if ((x >= xB1) && (x <= xB2) && (y >= yB1) && (y <= yB2))
			{
				insiderecB = true;
			}
			else
			{
				insiderecB = false;
			}

			if (insiderecA == false && insiderecB == false)
			{
				Console.WriteLine("outside");
			}
			else if (insiderecA == true || insiderecB == true || (y == yB1 && ((x > xB1) && (x < xB1 + h))))
			{
				Console.WriteLine("inside");
			}
			else
			{
				Console.WriteLine("border");
			}
		}
	}
}
