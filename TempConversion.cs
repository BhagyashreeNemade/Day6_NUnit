using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_NUnit
{
    public class TempConversion
    {
        public static int choice;
        public void FahrenheitToCelsuis()
        {

            Console.WriteLine("Enter a value of Fahrenheit");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            double far = fahrenheit - 32;
            float cal = 5 / 9;
            double result = (far * cal);
            Console.WriteLine("Celsuis :" + result);
        }

        public void CelsuisToFahrenheit()
        {
            Console.WriteLine("Enter a value of celsuis");
            double celsuis = Convert.ToDouble(Console.ReadLine());
            double result = ((celsuis * 9 / 5) + 32);
            Console.WriteLine("Fahrenheit :" + result);
        }
        public void Conversion()
        {
            while (choice != 3)
            {
                Console.WriteLine("\n1. Fahrenheit to Celsuis\n2.Celsuis to Fahrenheit\n3. Exit\nEnter your Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        FahrenheitToCelsuis();
                        break;
                    case 2:
                        CelsuisToFahrenheit();
                        break;
                    default:
                        Console.WriteLine("Oops!!! You Entered Wrong Input");
                        break;
                }
            }
        }
    }
}
