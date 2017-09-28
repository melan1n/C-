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

			var onborderA = false;
			var insiderecA = false;
			//Point inside/outside rectangle? Border is not a case here:
			if ((x > xA1) && (x < xA2) && (y > yA1) && (y < yA2))
			{
				insiderecA = true;
			}
			else if ((x < xA1) && (x > xA2) && (y < yA1) && (y > yA2))
			{
				insiderecA = false;
			}
			else if (((x == xA1 || x == xA2) && (y >= yA1 && y <= yA2)) || ((y == yA1 || y == yA2) && (x >= xA1 && x <= xA2)))
			{
				onborderA = true;
			}

			var onborderB = false;
			var insiderecB = false;
			//Point inside/outside rectangle? Border is not a case here:
			if ((x > xB1) && (x < xB2) && (y > yB1) && (y < yB2))
			{
				insiderecB = true;
			}
			else if ((x < xB1) && (x > xB2) && (y < yB1) && (y > yB2))
			{
				insiderecB = false;
			}
			else if (((x == xB1 || x == xB2) && (y >= yB1 && y<= yB2)) || ((y == yB1 || y == yB2) && (x >= xB1 && x <= xB2)))
			{
				onborderB = true;
			}

			if ((onborderA == true || onborderB == true) && !(y == yB1 && ((x > xB1) && (x < (xB1 + h)))))
			{
				Console.WriteLine("border");
			}
			else if (insiderecA == true || insiderecB == true || (y == yB1 && ((x > xB1) && (x < xB1 + h))))
			{
				Console.WriteLine("inside");
			}
			else //if (insiderecA == false && insiderecB == false)
			{
				Console.WriteLine("outside");
			}
				
			
			
		}
	}
}

