using System;

namespace FrancTests
{
    public class Franc
    {
        private int amount { get; set; }
        public Franc(int amount)
        {
            this.amount = amount;
        }

        public Franc Times(int num)
        {
            return new Franc(amount * num);
        }

        public override bool Equals(object obj)
        {
            Franc dollar = (Franc)obj;

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return amount == dollar.amount;
        }
    }
}