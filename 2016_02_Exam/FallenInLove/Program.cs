using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallenInLove
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			//Print first third (n rows)
			for (int i = 0; i < n; i++)
			{
				var leaf = "#" + new string('~', i) + "#";
				var back = new string('.', 2 * (n - i));
				var flower = "#" + new string('.', 2 * i) + "#";
				Console.WriteLine($"{leaf}{back}{flower}{back}{leaf}");
			}
			//Print second third (n+1 rows)
			for (int i = 0; i <= n; i++)
			{
				var leaf = "#" + new string('~', n - i) + "#";
				var back = new string('.', 2 * i + 1);
				var flower = new string('.', 2 * n - 2 * i);
				Console.WriteLine($"{back}{leaf}{flower}{leaf}{back}");
			}
			//Print third third (n rows)s
			for (int i = 0; i < n; i++)
			{
				var back = new string('.', 2 * n + 2);
				var flower = "##";
				Console.WriteLine($"{back}{flower}{back}");
			}
		}
	}
}
