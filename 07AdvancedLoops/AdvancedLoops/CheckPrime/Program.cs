using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPrime
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			string primalty = "Prime";

			for (int i = 2; i <= Math.Sqrt(n); i++)
			{
				if (n % i == 0 || n < 2)
				{
					primalty = "Not prime";
					break;					
				}
			}
			Console.WriteLine(primalty);
			
		}
	}
}

