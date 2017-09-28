using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Bills
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());

			var electricity = decimal.Parse(Console.ReadLine());
			decimal sumelectricity = 0;
						while (electricity != 0)
			{
				sumelectricity = sumelectricity + electricity;
				var total = (electricity + 35) * 120/100;
				Console.WriteLine("Electricity: {0:f2} lv", sumelectricity);
				Console.WriteLine("Water: {0:f2} lv", n*20);
				Console.WriteLine("Internet: {0:f2} lv", n*15);
				Console.WriteLine("Other: {0:f2} lv", total*20/100);
				Console.WriteLine("Average: {0:f2} lv", total/n);
			}
		}
	}
}
