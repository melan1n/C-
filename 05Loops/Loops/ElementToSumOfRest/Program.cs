using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementToSumOfRest
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var maxnum = 0;
			var sumrest = 0;

			for (int i = 0; i < n; i++)
			{
				var num = int.Parse(Console.ReadLine());
				sumrest = sumrest + num;
				if (num > maxnum)
				{
					maxnum = num;
				}
			}
			sumrest = sumrest - maxnum;

			if (maxnum == sumrest)
			{
				Console.WriteLine($"Yes, Sum = {maxnum}");
			}
			else
			{
				Console.WriteLine($"No, Diff = {Math.Abs(maxnum - sumrest)}");
			}
		}
	}
}
