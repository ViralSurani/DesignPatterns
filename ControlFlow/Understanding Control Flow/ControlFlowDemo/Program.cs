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
            int factor = 3;

            do
            {
                int digit = number % 10;

                sum = sum + (digit*factor);
                factor = 4 - factor;

                number = number / 10;                
            } while (number > 0);

            int result = sum % 11;

            if (result == 10)
                result = 1;

            return result;
        }
    }
}
