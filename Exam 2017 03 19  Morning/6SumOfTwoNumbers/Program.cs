using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6SumOfTwoNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			var a = int.Parse(Console.ReadLine());
			var b = int.Parse(Console.ReadLine());
			var c = int.Parse(Console.ReadLine());
			var combonr = 0;
			var result = "No";

			//if the sum of any two = c -> print
			//combo nr. num1 + num2 = c
			
			for (int i = a; i >= b; i--)
			{
				if (result == "Yes")
				{
					break;
				}
				for (int j = a; j >= b; j--)
				{
					var num1 = i;
					var num2 = j;
					var sum = num1 + num2;

					if (sum == c)
					{
						combonr++;
						result = "Yes";
						Console.WriteLine("Combination N:{0} ({1} + {2} = {3})",
					combonr, num1, num2, c);
						break;
					}
					else
					{
						combonr++;
					}
					
				}
			}
			//else nmber of combos - c
			if (result == "No")
			{
				Console.WriteLine("{0} combinations - neither equals {1}",
						   combonr, c);
			}
		}
	}
}
