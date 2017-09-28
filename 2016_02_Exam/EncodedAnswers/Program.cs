using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodedAnswers
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var answers = "";
			var suma = 0;
			var sumb = 0;
			var sumc = 0;
			var sumd = 0;

			for (int i = 1; i <= n; i++)
			{
				var num = int.Parse(Console.ReadLine());
				
				if (num % 4 == 0)
				{
					answers += "a "; suma += 1;
				}
				else if (num % 4 == 1)
				{
					answers += "b "; sumb += 1;
				}
				else if (num % 4 == 2)
				{
					answers += "c "; sumc += 1;
				}
				else //if (num % 4 == 3)
				{
					answers += "d "; sumd += 1;
				}
			
			}
			Console.WriteLine($"{answers}");
			Console.WriteLine($"Answer A: {suma}");
			Console.WriteLine($"Answer B: {sumb}");
			Console.WriteLine($"Answer C: {sumc}");
			Console.WriteLine($"Answer D: {sumd}");
			
		}
	}
}
