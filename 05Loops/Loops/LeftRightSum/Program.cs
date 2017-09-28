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
			var sumleft = 0;
			var sumright = 0;

			for (int i = 1; i <= n; i++)
			{
				var num = int.Parse(Console.ReadLine());
				sumleft = sumleft + num;
			}
			for (int j = 1; j <= n; j++)
			{
				var num = int.Parse(Console.ReadLine());
				sumright = sumright + num;
			}
			if (sumleft == sumright)
			{
				Console.WriteLine($"Yes, sum = {sumright}");
			}
			else
			{
				Console.WriteLine($"No, diff = {Math.Abs(sumleft - sumright)}");
			}
		}
	}
}
