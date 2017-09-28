using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8Risingsequence
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var result = 0;
			var num = Console.ReadLine();
			var prevnumber = 0;

			while (num != "")
			{
				var number = int.Parse(num);
				if (number > prevnumber)
				{
					result++;
				}
				else
				{
					result = 1;
				}
				prevnumber = number;
				num = Console.ReadLine();
				if (num=="")
				{
					break;
				}
			}
			Console.WriteLine(result);

		}
	}
}
