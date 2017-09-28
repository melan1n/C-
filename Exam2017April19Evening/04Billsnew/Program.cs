using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Billsnew
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());
			var electricitystring = Console.ReadLine();
			decimal sumelectricity = 0;
			
			while (electricitystring != "")
			{
				var electricity = decimal.Parse(electricitystring);
				sumelectricity = sumelectricity + electricity;
				electricitystring = Console.ReadLine();

			}
			var total = (sumelectricity + n*20 + n*15) * 120 / 100;
			
			Console.WriteLine("Electricity: {0:f2} lv", sumelectricity);
			Console.WriteLine("Water: {0:f2} lv", n * 20);
			Console.WriteLine("Internet: {0:f2} lv", n * 15);
			Console.WriteLine("Other: {0:f2} lv", total);
			Console.WriteLine("Average: {0:f2} lv", (sumelectricity+n*20+n*15+total)/ n);
		}
	}
}
