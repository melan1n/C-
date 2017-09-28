using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualPairs
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var firstnum1 = int.Parse(Console.ReadLine());
			var firstnum2 = int.Parse(Console.ReadLine());
			var sumprevpair = firstnum1 + firstnum2;

			var maxdiff = sumprevpair - sumprevpair;
			
			var allequal = true;
			//var sumpair = sumprevpair;

			for (int i = 1; i < n; i++)
			{
				var num1 = int.Parse(Console.ReadLine());
				var num2 = int.Parse(Console.ReadLine());
				var sumpair = num1 + num2;

				if (sumpair != sumprevpair)
				{
					allequal = false;
					if (sumpair > sumprevpair)
					{
						maxdiff = Math.Max(maxdiff, (sumpair - sumprevpair));
					}
					else if (sumpair < sumprevpair)
					{
						maxdiff = Math.Max(maxdiff, Math.Abs(sumpair - sumprevpair));
					}
				}

				sumprevpair = sumpair;
			}
			
			if (allequal == true)
			{
				Console.WriteLine($"Yes, value={sumprevpair}");
			}
			else
			{
				Console.WriteLine($"No, maxdiff={maxdiff}");
			}
		}
	}
}
