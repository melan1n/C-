using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radians_To_Degrees
{
	class Program
	{
		static void Main(string[] args)
		{
			// degrees = radians * 180/pi
			var radians = double.Parse(Console.ReadLine());

			var degrees = radians * 180 / Math.PI;

			Console.WriteLine(Math.Round(degrees));
		}
	}
}
