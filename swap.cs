using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_NUnit
{
    public class Binary
    {
        public static string answer, result;
        public static int num;
        public static void toBinary(int num)
        {
            result = "";
            while (num > 1)
            {
                int remainder = num % 2;
                Binary.result = Convert.ToString(remainder) + Binary.result;
                num /= 2;
            }
            Binary.result = Convert.ToString(num) + Binary.result;
            Console.WriteLine($"Binary: {Binary.result}");

        }
        public void Swap(int num)
        {
            Console.WriteLine(Convert.ToString(((Binary.num & 0x0F) << 4) | ((Binary.num & 0xF0) >> 4)));
        }
    }
}
