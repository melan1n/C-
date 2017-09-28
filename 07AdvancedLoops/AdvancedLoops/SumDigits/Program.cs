using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigits
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var sumdigits = 0;
			do
			{
				var lastdigit = n % 10;
				sumdigits = sumdigits + lastdigit;
				n = n / 10;
			} while(n>0);
			Console.WriteLine(sumdigits);
		}
	}
}
