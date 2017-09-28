using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimePlus15Mins
{
	class Program
	{
		static void Main(string[] args)
		{
			int hours = int.Parse(Console.ReadLine());
			int minutes = int.Parse(Console.ReadLine());
			int time = hours * 60 + minutes;
			int time_new = time + 15;
			int hours_result = time_new / 60;
			int minutes_result = time_new % 60;

			if (hours_result == 24)
			{
				hours_result = 0;
			}

			if (minutes_result < 10)
			{
				Console.WriteLine($"{hours_result}:0{minutes_result}");
			}
			else 
			{
				Console.WriteLine($"{hours_result}:{minutes_result}");
			}
			
		}
	}
}
