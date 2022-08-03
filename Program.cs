namespace Day6_NUnit
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter the program number which is to be executed \n 1. Vending Machine \n 2. Day Of Week \n 3. Temp Conversion \n 4. Monthly Payment \n 5. Square root using Newtons Law \n 6. Swap Binary \n 7. Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter Amount");
                        int amount = Convert.ToInt32(Console.ReadLine());
                        VendingMachine.countCurrency(amount);
                        break;
                    case 2:
                        DayOfWeek dayOfWeek = new DayOfWeek();
                        dayOfWeek.Day();
                        break;
                    case 3:
                        TempConversion tempconversion = new TempConversion();
                        tempconversion.Conversion();
                        break;
                    case 4:
                        MonthlyPayment.Payment();
                        break;
                    case 5:
                        NewtonsMethod.Sqrt();
                        break;
                    case 6:
                        Binary b = new Binary();
                        Console.Write("Input a Number : ");
                        Binary.num = Convert.ToInt32(Console.ReadLine());
                        Binary.toBinary(Binary.num);
                        b.Swap(Binary.num);
                        break;
                    case 7:
                        flag = false;
                        break;
                }
            }
        }
    }
}
