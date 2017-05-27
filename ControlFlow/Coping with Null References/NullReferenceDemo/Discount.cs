using System;

namespace NullReferenceDemo
{
    class Discount
    {
        private readonly string _description;
        private readonly decimal _relativeDiscount;

        public Discount(string description, decimal relativeDiscount)
        {
            if (relativeDiscount <= 0 || relativeDiscount >= 1)
            {
                throw new ArgumentException("Incorrect discount", "relativeDiscount");
            }
            _description = description;
            _relativeDiscount = relativeDiscount;
        }

        public decimal Apply(decimal price)
        {
            return price * (1.0M - _relativeDiscount);
        }

        public override string ToString()
        {
            return string.Format("{0}% {1}", _relativeDiscount * 100, _description);
        }
    }
}
