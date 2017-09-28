using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6Sumsofthreenumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			var a = int.Parse(Console.ReadLine());
			var b = int.Parse(Console.ReadLine());
			var c = int.Parse(Console.ReadLine());

			if ((a+b) == c )	
			{
				Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
			}
			else if ((a + c) == b)
			{
				Console.WriteLine("{0} + {1} = {2}", a, c, a + c);
			}
			else if ((c + b) == a)
			{
				Console.WriteLine("{0} + {1} = {2}", b, c, b + c);
			}
			else
			{
				Console.WriteLine("No");
			}
			
		}
	}
}
