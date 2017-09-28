using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4LecturersSalary
{
	class Program
	{
		static void Main(string[] args)
		{
			var lectures = int.Parse(Console.ReadLine());
			var budget = float.Parse(Console.ReadLine());
			var lecturer = Console.ReadLine();

			var JelevLectures = 0;
			var RoYaLLectures = 0;
			var RoliLectures = 0;
			var TrofonLectures = 0;
			var SinoLectures = 0;
			var OtherLectures = 0;

			for (int i = 0; i < lectures; i++)
			{
				switch (lecturer)
				{
					case ("Jelev"): JelevLectures++;break;
					case ("RoYaL"): RoYaLLectures++;break;
					case ("Roli"): RoliLectures++; break;
					case ("Trofon"): TrofonLectures++; break;
					case ("Sino"): SinoLectures++; break;
					default: OtherLectures++; break;
				}
				lecturer = Console.ReadLine();
			}
			Console.WriteLine("Jelev salary: {0:f2} lv", JelevLectures * budget / lectures);
			Console.WriteLine("RoYaL salary: {0:f2} lv", RoYaLLectures * budget / lectures);
			Console.WriteLine("Roli salary: {0:f2} lv", RoliLectures * budget / lectures);
			Console.WriteLine("Trofon salary: {0:f2} lv", TrofonLectures * budget / lectures);
			Console.WriteLine("Sino salary: {0:f2} lv", SinoLectures * budget / lectures);
			Console.WriteLine("Others salary: {0:f2} lv", OtherLectures * budget / lectures);

		}
	}
}
