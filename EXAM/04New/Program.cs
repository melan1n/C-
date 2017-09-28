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
			var parts = int.Parse(Console.ReadLine());
			var pricePerPoint = double.Parse(Console.ReadLine());
			int points = 0;

			for (int i = 1; i <= parts; i++)
			{
				if (i == 1 || i % 2 == 1)
				{
					points = points + int.Parse(Console.ReadLine());

				}
				else if (i % 2 == 0)
				{
					points = points + int.Parse(Console.ReadLine()) * 2;
				}
			}

			Console.WriteLine("The project prize was {0:f2} lv.", points * pricePerPoint);
		}
	}
}
