using System;
using MoneyTests;

namespace FrancTests
{
    public class Franc : Money
    {
        public Franc(int amount)
        {
            this.amount = amount;
        }

        public override Money Times(int num)
        {
            return new Franc(amount * num);
        }
    }
}