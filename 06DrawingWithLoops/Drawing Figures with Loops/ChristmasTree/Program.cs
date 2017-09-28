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
			Console.Write(new string(' ', n + 1));
			Console.Write('|');
			Console.WriteLine();

			for (int i = 1; i <= n; i++)
			{
							
				Console.Write(new string(' ', n-i));
				Console.Write(new string('*', i));
				Console.Write(" | ");
				Console.Write(new string('*', i));
				Console.WriteLine();
			}
			
		}
	}
}
