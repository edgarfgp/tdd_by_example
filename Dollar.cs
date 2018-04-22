using System;
using MoneyTests;

namespace MoneyTests
{
    public class Dollar : Money
    {
        
        public Dollar(int amount)
        {
            this.amount = amount;
        }

        public override Money Times(int num)
        {
            return new Dollar(amount * num);
        }

    }
}