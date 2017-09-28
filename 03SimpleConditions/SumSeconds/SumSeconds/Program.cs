using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumSeconds
{
	class Program
	{
		static void Main(string[] args)
		{
			var result_1 = int.Parse(Console.ReadLine());
			var result_2 = int.Parse(Console.ReadLine());
			var result_3 = int.Parse(Console.ReadLine());
			int result = result_1 + result_2 + result_3;
			int result_min = result / 60;
			int result_sec = result % 60;

			if (result_sec < 10)
			{
				Console.WriteLine($"{result_min}:0{result_sec}");
			}
			else
			{
				Console.WriteLine($"{result_min}:{result_sec}");
			}
		
		}
	}
}
