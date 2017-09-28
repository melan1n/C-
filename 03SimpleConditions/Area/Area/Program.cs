using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
	class Program
	{
		static void Main(string[] args)
		{
			string figure = Console.ReadLine();

			if (figure == "square")
			{
				double side_length = double.Parse(Console.ReadLine());
				double area = 0.000;
				area = side_length * side_length;
				Console.WriteLine(area); 
			}
			else if (figure == "rectangle")
			{
				double side1_length = double.Parse(Console.ReadLine());
				double side2_length = double.Parse(Console.ReadLine());
				double area = 0.000;
				area = side1_length * side2_length;
				Console.WriteLine(area);
			}
			else if (figure == "circle")
			{
				double radius = double.Parse(Console.ReadLine());
				double area = 0.000;
				area = Math.PI * Math.Pow(radius, 2);
				Console.WriteLine(area);
			}
			else if (figure == "triangle")
			{
				double side_length = double.Parse(Console.ReadLine());
				double height = double.Parse(Console.ReadLine());
				double area = 0.000;
				area = side_length * height / 2;
				Console.WriteLine(area);
			}
		}
	}
}
