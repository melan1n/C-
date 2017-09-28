using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberTable
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var num = 1;

			for (var row = 0; row <= n-1; row++)
			{
				for (var col = 0; col <= n - 1; col++)
				{
					if (row + col < n)
					{
						Console.Write(num = row + col + 1);
					}
					if (row + col >= n)
					{
						Console.Write(num = num - 1);
					}
					Console.Write(" ");
				}
				Console.WriteLine();
			}
		}
	}
}
