using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
	class Program
	{
		static void Main(string[] args)
		{
			var record = double.Parse(Console.ReadLine());
			var meters = double.Parse(Console.ReadLine());
			var speed = double.Parse(Console.ReadLine());

			var time = meters * speed + Math.Floor(meters / 15) * 12.5;

			if (time<record)
			{
				Console.WriteLine("Yes, he succeeded! The new world record is {0:f2} seconds.", time);
			}
			else
			{
				Console.WriteLine("No, he failed! He was {0:f2} seconds slower.", time - record);
			}
		}
	}
}
