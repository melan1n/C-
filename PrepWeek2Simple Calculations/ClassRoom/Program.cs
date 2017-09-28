using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
	class Program
	{
		static void Main(string[] args)
		{
			var h = double.Parse(Console.ReadLine()) * 100;
			var w = double.Parse(Console.ReadLine()) * 100 - 100;

			var rows = Math.Floor(h / 120);
			var columns = Math.Floor(w / 70);

			Console.WriteLine(rows * columns - 3);

		}
	}
}
