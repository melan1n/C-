using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6LettersCombinations
{
	class Program
	{
		static void Main(string[] args)
		{
			var start = char.Parse(Console.ReadLine());
			var end = char.Parse(Console.ReadLine());
			var skip = char.Parse(Console.ReadLine());

			int combos = 0;
			
			for (char i = start; i <= end; i++)
			{
				if (i != skip)
				{
					for (char j = start; j <= end; j++)
					{
						if (j != skip)
						{
							for (char k = start; k <= end; k++)
							{
								if (k != skip)
								{
									Console.Write("{0}{1}{2} ", i, j, k);
									combos++;
								}
								
							}
						}
												
					}
				}
							
			}
			Console.Write("{0}", combos);
		}
	}
}
