using System;

namespace ControlFlowDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CalculateControlDigit(82712476));
            Console.ReadKey();
        }

        static int CalculateControlDigit(int number)
        {
            int sum = 0;
            int pos = 1;

            do
            {
                int digit = number % 10;

                int value;
                if (pos % 2 == 0)
                    value = digit * 3;
                else
                    value = digit;

                sum = sum + value;

                number = number / 10;
                pos = pos + 1;
            } while (number > 0);

            int result = sum % 11;

            if (result == 10)
                result = 1;

            return result;
        }
    }
}
