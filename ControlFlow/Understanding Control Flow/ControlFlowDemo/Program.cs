using System;

namespace ControlFlowDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateControlDigit(82712476));

            Console.WriteLine("{0:C}", GetItemPrice("laptop", 0.15M));
            Console.WriteLine("{0:C}", GetItemPrice("pen"));

            Console.ReadKey();
        }

        static int CalculateControlDigit(int number)
        {
            int sum = 0;
            int factor = 3;
            do
            {
                int digit = number % 10;
                sum = sum + (digit * factor);
                factor = 4 - factor;
                number = number / 10;
            } while (number > 0);

            int result = sum % 11;
            if (result == 10)
                result = 1;
            return result;
        }

        private static decimal GetItemPrice(string itemName, decimal relativeDiscount)
        {
            if (relativeDiscount <= 0 || relativeDiscount >= 1)
            {
                throw new ArgumentException("Incorrect discount", "relativeDiscount");
            }
            Console.WriteLine("LOG Discount {0}% applied", 100 * relativeDiscount);
            return GetItemPrice(itemName) * (1.0M - relativeDiscount);
        }

        private static decimal GetItemPrice(string itemName)
        {
            return 100.0M * itemName.Length;
        }
    }
}
