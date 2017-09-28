using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celsius_To_Farenheit
{
	class Program
	{
		static void Main(string[] args)
		{
			//Multiply by 9, then divide by 5, then add 32
			var celsius = double.Parse(Console.ReadLine());
			var farenheit = celsius * 9 / 5 + 32;

			Console.WriteLine(Math.Round(farenheit, 2));
		}
	}
}
