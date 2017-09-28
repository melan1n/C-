using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			int sum = 0;

			for (int i = 1; i <= n; i++)
			{
				sum = sum + int.Parse(Console.ReadLine());
			}

			Console.WriteLine(sum);
		}
	}
}
