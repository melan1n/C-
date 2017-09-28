using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5DateInFiveDays
{
	class Program
	{
		static void Main(string[] args)
		{
			var d = int.Parse(Console.ReadLine());
			var m = int.Parse(Console.ReadLine());
			
			
			if ((m==1 || m==3 || m==5 || m==7 || m==8 || m==10 || m==12) && (d <= 31 - 5))
			{
				d = d + 5;
			}
			else if ((m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10) && (d > 31 - 5))
			{
				d = 5 - (31 - d);
				m++;
			}
			else if ((m == 12) && (d > 31 - 5))
			{
				d = 5 - (31 - d);
				m = 1;
			}
			
			else if ((m == 4 || m == 6 || m == 9 || m == 11) && (d <= 30 - 5))
			{
				d = d + 5;
			}
			else if ((m == 4 || m == 6 || m == 9 || m == 11) && (d > 30 - 5))
			{
				d = 5 - (30 - d);
				m++;
			}
			
			else if ((m == 2) && (d <= 28 - 5))
			{
				d = d + 5;
			}
			else if ((m == 2) && (d > 28 - 5))
			{
				d = 5 - (28 - d);
				m++;
			}
			if (m<10)
			{
			Console.WriteLine("{0}.{1}{2}", d, "0", m);

			}
			else
			{
				Console.WriteLine("{0}.{1}", d, m);
			}
		}
	}
}
