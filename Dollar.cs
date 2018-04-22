using System;

namespace DollarTests
{
    public class Dollar
    {
        private int amount { get; set; }
        public Dollar(int amount)
        {
            this.amount = amount;
        }

        public Dollar Times(int num)
        {
            return new Dollar(amount * num);
        }

        public override bool Equals(object obj)
        {
            Dollar dollar = (Dollar)obj;

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return amount == dollar.amount;
        }
    }
}