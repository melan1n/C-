using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodedAnswersNew
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			string answers = null;
			int suma = 0;
			int sumb = 0;
			int sumc = 0;
			int sumd = 0;

			for (int i = 1; i <= n; i++)
			{
				var num = int.Parse(Console.ReadLine())%4;
				var answer = "";

				switch (num)
				{
					case (0): answer = "a"; suma += 1; break;
					case (1): answer = "b"; sumb += 1; break;
					case (2): answer = "c"; sumc += 1; break;
					case (3): answer = "d"; sumd += 1; break;
						
				}

				answers = answers + answer + ' ';
			}
			Console.WriteLine($"{answers}");
			Console.WriteLine("Answer A: {0}\nAnswer B: {1}\nAnswer C: {2}\nAnswer D: {3}", suma, sumb, sumc, sumd);
		}
	}
}

