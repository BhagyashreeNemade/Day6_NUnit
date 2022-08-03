using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_NUnit
{
    public class DayOfWeek
    {
        public void Day()
        {
            Console.WriteLine("Enter day");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter month");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter year");
            int year = Convert.ToInt32(Console.ReadLine());
            int Y = year - (14 - month) / 12;
            int X = Y + Y / 4 - Y / 100 + Y / 400;
            int M = month + 12 * ((14 - month) / 12) - 2;
            int D = (day + X + (31 * M) / 12) % 7;
            switch (D)
            {
                case 1:
                    Console.WriteLine("Day Of Week Is Sunday");
                    break;
                case 2:
                    Console.WriteLine("Day Of Week Is Monday");
                    break;
                case 3:
                    Console.WriteLine("Day Of Week Is Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Day Of Week Is Wensday");
                    break;
                case 5:
                    Console.WriteLine("Day Of Week Is Thuesday");
                    break;
                case 6:
                    Console.WriteLine("Day Of Week Is Friday");
                    break;
                case 7:
                    Console.WriteLine("Day Of Week Is Saturday");
                    break;
                default:
                    break;
            }
        }
    }
}
