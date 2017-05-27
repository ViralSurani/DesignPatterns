using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullReferenceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Discount discount = new Discount("loyalty discount", 0.15M);

            Console.WriteLine("{0:C}", GetItemPrice("laptop", discount));
            Console.WriteLine("{0:C}", GetItemPrice("pen", null));

            Console.ReadKey();
        }

        private static decimal GetItemPrice(string itemName, Discount discount)
        {

            decimal basePrice = 100.0M * itemName.Length;

            if (discount == null)
                return basePrice;

            Console.WriteLine("LOG applying {0}", discount);

            return discount.Apply(basePrice);
        }
    }
}
