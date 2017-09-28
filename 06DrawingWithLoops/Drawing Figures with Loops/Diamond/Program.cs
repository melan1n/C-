using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
	class Program
	{
		static void Main(string[] args)
		{
			var n = int.Parse(Console.ReadLine());

			if (n == 2)
			{
				Console.WriteLine("**");
			}
			else if (n%2 == 1)
			{
				int midrow = n / 2 + 1;
				var leftright = (n - 1) / 2;

				for (int i = 1; i <= midrow; i++)
				{

					var mid = n - 2 * leftright - 2;

					if (mid >= 0 && i <= midrow)
					{

						Console.WriteLine("{0}{1}{2}{3}{4}",
						new string('-', leftright),
						"*",
						new string('-', mid),
						"*",
						new string('-', leftright)
						);

					}
					else if (mid < 0 && i <= midrow)
					{

						Console.WriteLine("{0}{1}{2}",
						new string('-', leftright),
						"*",
						new string('-', leftright)
						);
					}
					leftright -= 1;
					mid += 2;
				}

				var leftrightbottom = 1;
				for (int j = midrow + 1; j <= n; j++)
				{

					var mid = n - 2 * leftrightbottom - 2;

					if (mid >= 0)
					{
						Console.WriteLine("{0}{1}{2}{3}{4}",
						new string('-', leftrightbottom),
						"*",
						new string('-', mid),
						"*",
						new string('-', leftrightbottom)
						);

					}
					else if (mid < 0)
					{

						Console.WriteLine("{0}{1}{2}",
						new string('-', leftrightbottom),
						"*",
						new string('-', leftrightbottom)
						);

					}
					leftrightbottom += 1;
					mid -= 2;
				}
			}

			else if (n % 2 == 0)
			{
				int midrow = n / 2 + 1;
				var leftright = (n - 1) / 2;

				for (int i = 1; i <= midrow; i++)
				{

					var mid = n - 2 * leftright - 2;

					if (mid >= 0 && i <= midrow && leftright >=0)
					{

						Console.WriteLine("{0}{1}{2}{3}{4}",
						new string('-', leftright),
						"*",
						new string('-', mid),
						"*",
						new string('-', leftright)
						);

					}
					else if (mid < 0 && i <= midrow && leftright >=0)
					{

						Console.WriteLine("{0}{1}{2}",
						new string('-', leftright),
						"*",
						new string('-', leftright)
						);
					}
					leftright -= 1;
					mid += 2;
				}

				var leftrightbottom = 1;
				for (int j = midrow + 1; j <= n; j++)
				{

					var mid = n - 2 * leftrightbottom - 2;

					if (mid >= 0)
					{
						Console.WriteLine("{0}{1}{2}{3}{4}",
						new string('-', leftrightbottom),
						"*",
						new string('-', mid),
						"*",
						new string('-', leftrightbottom)
						);

					}
					else if (mid < 0)
					{

						Console.WriteLine("{0}{1}{2}",
						new string('-', leftrightbottom),
						"*",
						new string('-', leftrightbottom)
						);

					}
					leftrightbottom += 1;
					mid -= 2;
				}
			}
		}
	}
}
