using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassionDays
{
	class Program
	{
		static void Main(string[] args)
		{
			var money = decimal.Parse(Console.ReadLine());
			var enter = Console.ReadLine();
			decimal numberofpurchases = 0;
			while (money > 0 && enter == "mall.Enter")
			{	//Get price, apply discount, add or subtract to/from money
				var nextline = Console.ReadLine();
				if (nextline == "mall.Exit")
				{
					break;
				}
				else
				{
					foreach (char c in nextline)
					{
						if (c >= 65 && c <= 90)
						{
							numberofpurchases += 1; money = money - c*0.5m;
						}
						else if (c >= 97 && c <= 122)
						{
							numberofpurchases += 1; money = money - c*0.3m;
						}
						else if (c == 37)
						{
							numberofpurchases += 1; money = money / 2;
						}
						else if (c == 42)
						{
							numberofpurchases += 0; money = money + 10;
						}
					}
				}
			}
			if (numberofpurchases == 0)
			{
				Console.WriteLine("No purchases. Money left: {0} lv.", money.ToString("0.00"));
			}
			else
			{
				Console.WriteLine("{0} purchases. Money left: {1:f2} lv.", numberofpurchases, money);
			}
		}
	}
}
