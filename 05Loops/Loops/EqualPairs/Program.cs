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

			var allmin = sumprevpair;
			var allmax = sumprevpair;
			
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
					if (sumpair > allmax)
					{
						allmax = sumpair;
						//maxdiff = Math.Max(maxdiff, (sumpair - min));
					}
					else if (sumpair < allmin)
					{
						allmin = sumpair;
						//maxdiff = Math.Max(maxdiff, Math.Abs(sumpair - min));
					}
				}

				sumprevpair = sumpair;
			}
			var maxdiff = allmax - allmin;
			if (allequal == true)
			{
				Console.WriteLine($"Yes, value={allmin}");
			}
			else
			{
				Console.WriteLine($"No, maxdiff={maxdiff}");
			}
		}
	}
}
