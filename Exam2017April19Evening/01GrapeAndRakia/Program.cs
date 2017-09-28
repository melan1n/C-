using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01GrapeAndRakia
{
	class Program
	{
		static void Main(string[] args)
		{
			var area = double.Parse(Console.ReadLine());
			var kgpermeter = double.Parse(Console.ReadLine());
			var brak = double.Parse(Console.ReadLine());

			var grapes = area * kgpermeter - brak;

			var grapesforsale = grapes * 0.55;
			var grapesforrakia = grapes * 0.45;

			var litersofrakia = grapesforrakia / 7.5;

			var grapesincome = grapesforsale * 1.50;
			var rakiaincome = litersofrakia * 9.80;

			Console.WriteLine("{0:f2}", rakiaincome);
			Console.WriteLine("{0:f2}", grapesincome);


		}
	}
}
