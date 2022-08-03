using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_NUnit
{
	public class MonthlyPayment
	{
		public static double P, Y, R;
		public static void Payment()
		{
			Console.WriteLine("Enter principle amount");
			P = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter Year");
			Y = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter Rate of interest");
			R = Convert.ToInt32(Console.ReadLine());
			double n = 12 * Y;
			double r = R / (12 * 100);
			double payment = (P * r) / 1 - (Math.Pow(1 + r, -n));
			Console.WriteLine("Monthly Payment is : " + payment);
		}
	}
}
