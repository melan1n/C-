using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06ControlNumber
{
	class Program
	{
		static void Main(string[] args)
		{
			var N = ulong.Parse(Console.ReadLine());
			var M = ulong.Parse(Console.ReadLine());
			var control = ulong.Parse(Console.ReadLine());

			ulong moves = 0;
			ulong sum = 0;

			for (ulong i = 1; i <= N; i++)
			{
				for (ulong j = M; j >= 1 ; j--)
				{
					sum = sum + i * 2 + j * 3;
					moves++;
					if (sum >= control)
					{
						break;
					}
				}
			}
			if (sum>=control)
			{
				Console.WriteLine("{0} moves", moves);
				Console.WriteLine("Score: {0} >= {1}", sum, control);
			}
			else if (sum < control)
			{
				Console.WriteLine("{0} moves", moves);
			}
		}
	}
}
