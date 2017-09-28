using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertor
{
	class Program
	{
		static void Main(string[] args)
		{
			var metric = double.Parse(Console.ReadLine());
			var input = Console.ReadLine();
			var output = Console.ReadLine();

			double input_to_meter = 0.0;
			double result = 0.0;

			if (input == "mm")
			{
				input_to_meter = metric / 1000;
			}
			else if(input == "cm")
			{
				input_to_meter = metric / 100;
			}
			else if (input == "mi")
			{
				input_to_meter = metric * (1/0.000621371192);
			}
			else if (input == "in")
			{
				input_to_meter = metric / 39.3700787;
			}
			else if (input == "km")
			{
				input_to_meter = metric * 1000;
			}
			else if (input == "ft")
			{
				input_to_meter = metric / 3.2808399;
			}
			else if (input == "yd")
			{
				input_to_meter = metric / 1.0936133;
			}
			else if (input == "m")
			{
				input_to_meter = metric;
			}

			if (output == "mm")
			{
				result = input_to_meter * 1000;
			}
			else if (output == "cm")
			{
				result = input_to_meter * 100;
			}
			else if (output == "mi")
			{
				result = input_to_meter * 0.000621371192;
			}
			else if (output == "in")
			{
				result = input_to_meter * 39.3700787;
			}
			else if (output == "km")
			{
				result = input_to_meter * 0.001;
			}
			else if (output == "ft")
			{
				result = input_to_meter * 3.2808399;
			}
			else if (output == "yd")
			{
				result = input_to_meter * 1.0936133;
			}
			else if (output == "m")
			{
				result = input_to_meter;
			}
			Console.WriteLine($"{result} {output}"); 


		}
	}
}
