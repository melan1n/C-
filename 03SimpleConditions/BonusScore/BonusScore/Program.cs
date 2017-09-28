using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusScore
{
	class Program
	{
		static void Main(string[] args)
		{
			var score = double.Parse(Console.ReadLine());
			double bonus_1 = 0.0;
			double bonus_2 = 0.0;
			
			
			if (score <= 100)
			{
				bonus_1 = 5.0;
			}
			else if (score > 100 && score < 1000)
			{
				bonus_1 = score / 5;
			}
			else
			{
				bonus_1 = score / 10;
			}
			if (score % 2 == 0)
			{
				bonus_2 = 1.0;
			}
			else if (score % 5 == 0 && score % 10 != 0)
			{
				bonus_2 = 2.0;
			}

			double bonus = bonus_1 + bonus_2;
			double total = score + bonus_1 + bonus_2;

			Console.WriteLine(bonus);
			Console.WriteLine(total);
		}
	}
}
