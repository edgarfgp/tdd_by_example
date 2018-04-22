using System;
namespace TDD.Logic
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