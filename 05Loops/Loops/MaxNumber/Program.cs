using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumber
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var maxnum = int.Parse(Console.ReadLine());

			for (int i = 1; i <= (n - 1); i++)
			{
				var num = int.Parse(Console.ReadLine());

				if (num > maxnum)
				{
					maxnum = num;
				}
			}

			Console.WriteLine(maxnum);
		}
	}
}
