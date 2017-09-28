using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RhombusOfStars
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());

			for (int i = 1; i <= n; i++)
			{
				var j = n-i;
				Console.Write(new string(' ', j));
				Console.Write('*');
				for (int m = 1; m < i; m++)
				{
					Console.Write(" *");
				}
				Console.WriteLine();
			}
			for (int i = n - 1; i >= 1; i--)
			{
				var j = n - i;
				Console.Write(new string(' ', j));
				Console.Write('*');
				for (int m = 1; m < i; m++)
				{
					Console.Write(" *");
				}
				Console.WriteLine();
			}
		}
	}
}
