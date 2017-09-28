using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cross_Currency
{
	class Program
	{
		static void Main(string[] args)
		{
			var amount = double.Parse(Console.ReadLine());
			var input_cur = Console.ReadLine();
			var output_cur = Console.ReadLine();
			var bgn_usd = 1.79549;
			var bgn_eur = 1.95583;
			var bgn_gbp = 2.53405;
			var bgn_amount = 0.0;
			var output_cur_amount = 0.0;

			if (input_cur == "USD")
				bgn_amount = amount * bgn_usd;
			if(input_cur == "EUR")
				bgn_amount = amount * bgn_eur;
			if(input_cur == "GBP")
				bgn_amount = amount * bgn_gbp;
			if(input_cur == "BGN")
				bgn_amount = amount;


			if(output_cur == "USD")
				output_cur_amount = bgn_amount / 1.79549;
			if(output_cur == "EUR")
				output_cur_amount = bgn_amount / 1.95583;
			if(output_cur == "GBP")
				output_cur_amount = bgn_amount / 2.53405;
			if(output_cur == "BGN")
				output_cur_amount = bgn_amount;

			var result = Math.Round(output_cur_amount, 2);

			Console.WriteLine($"{result} {output_cur}");
		}
	}
}
