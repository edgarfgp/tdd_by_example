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

        public Dollar Times(int num)
        {
            return new Dollar(amount * num);
        }

    }
}