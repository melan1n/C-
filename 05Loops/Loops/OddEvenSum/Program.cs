using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftRightSum
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var sumodd = 0;
			var sumeven = 0;

			for (int i = 1; i <= n; i++)
			{
				if (i % 2 == 0)
				{
					var num = int.Parse(Console.ReadLine());
					sumeven = sumeven + num;
				}
				else if (i % 2 == 1)
				{
					var num = int.Parse(Console.ReadLine());
					sumodd = sumodd + num;
				}
			}
			if (sumodd == sumeven)
			{
				Console.WriteLine($"Yes, sum = {sumodd}");
			}
			else
			{
				Console.WriteLine($"No, diff = {Math.Abs(sumodd - sumeven)}");
			}
		}
	}
}
