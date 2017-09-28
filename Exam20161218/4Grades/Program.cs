using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4Grades
{
	class Program
	{
		static void Main(string[] args)
		{
			var students = int.Parse(Console.ReadLine());
			double fiveAndOver = 0.0d;
			double fourAndOver = 0.0d;
			double threeAndOver = 0.0d;
			double fail = 0.0d;
			double gradessum = 0.0d;

			for (int i = 0; i < students; i++)
			{
				var grade = double.Parse(Console.ReadLine());
				if (grade >= 5.00)
				{
					fiveAndOver++; 
				}
				else if (grade >= 4.00 && grade <= 4.99 )
				{
					fourAndOver++;
				}
				else if (grade >= 3.00 && grade <= 3.99)
				{
					threeAndOver++;
				}
				else if (grade < 3.00)
				{
					fail++;
				}
				gradessum = gradessum + grade;
				
			}

			Console.WriteLine("Top students: {0:f2}%", fiveAndOver/students*100);
			Console.WriteLine("Between 4.00 and 4.99: {0:f2}%", fourAndOver / students * 100);
			Console.WriteLine("Between 3.00 and 3.99: {0:f2}%", threeAndOver / students * 100);
			Console.WriteLine("Fail: {0:f2}%", fail / students * 100);
			Console.WriteLine("Average: {0:f2}", gradessum / students);


		}
	}
}
