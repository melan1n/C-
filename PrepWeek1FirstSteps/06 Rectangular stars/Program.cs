using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Rectangular_stars
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
				Console.WriteLine(new string('*', n));
					for (int i = 2; i <= n - 1; i++)
					{
						Console.WriteLine('*' + new string(' ', n - 2) + '*');
					}	
				Console.WriteLine(new string('*', n));
		}
	}
}
