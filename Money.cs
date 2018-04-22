using System;

namespace MoneyTests
{
    public class Money
    {
        public double amount { get; set; }

        public Money(double amount)
        {
            this.amount = amount;
        }

        public Money Times(double num)
        {
            return new Money(Math.Round(amount *= num));
        }

        
        public override bool Equals(object obj)
        {
            Money money = (Money)obj;

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return amount == money.amount;
        }


    }
}