using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06NumberGenerator
{
	class Program
	{
		static void Main(string[] args)
		{
			var M = Console.ReadLine();
			var N = Console.ReadLine();
			var L = Console.ReadLine();
			var special = int.Parse(Console.ReadLine());
			var control = int.Parse(Console.ReadLine());


			var MNL = int.Parse(M + N + L);
			for (int i = MNL; i >= 111 ; i--)
			{
				if (i%3==0)
				{
					special += 5; 
				}
				else if (i%10==5)
				{
					special -= 2; 
				}
				else if (i%2==0)
				{
					special *= 2; 
				}
				if (special >= control)
				{
					break;
				}
			}
			if (special >= control)
			{
				Console.WriteLine("Yes! Control number was reached! Current special number is {0}.", special);
			}
			else
			{
				Console.WriteLine("No! {0} is the last reached special number.", special);
			}
		}
	}
}
