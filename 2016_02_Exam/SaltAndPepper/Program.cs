using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaltAndPepper
{
	class Program
	{
		static void Main(string[] args)
		{//Convert decimal to 64-bit binary string
			var integer = int.Parse(Console.ReadLine());
			var bin = Convert.ToString(integer, 2);
			var binary = new string('0', 64 - bin.Length) + Convert.ToString(integer, 2);
			
			//while next line != end loop (if salt -> set 0 to step position, if pepper -> set 1 to step position)
			var nextline = Console.ReadLine().Split(' ');
			while (nextline[0] != "end")
			{
				var spice = nextline[0];
				var step = int.Parse(nextline[1]);

				if (spice == "salt")
				{
					for (int i = 63; i >= 0; i -= step)
					{
						//if (binary[i] == '1')
						//{
						StringBuilder newbinnary = new StringBuilder(binary);
						newbinnary[i] = '0';
						binary = newbinnary.ToString();
						//} 
					}
				}
				else if (spice == "pepper")
				{
					for (int j = 63; j >= 0; j -= step)
					{
						if (binary[j] == '0')
						{
							StringBuilder newbinnary = new StringBuilder(binary);
							newbinnary[j] = '1';
							binary = newbinnary.ToString();
						}
					}
				}
				nextline = Console.ReadLine().Split(' ');
			}
			//Convert  64-bit binary string  to decimal and output
			Console.WriteLine(Convert.ToInt32(binary, 2));
		}
	}
}
