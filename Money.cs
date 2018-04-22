using FrancTests;

namespace MoneyTests
{
    public abstract class Money
    {
        protected int amount { get; set; }

        public abstract Money Times(int amount);
        public static Dollar dollar(int amount)
        {
            return new Dollar(amount);
        }

        public static Franc franc(int amount)
        {
            return new Franc(amount);
        }

        public override bool Equals(object obj)
        {
            Money dollar = (Money)obj;

            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            return amount == dollar.amount;
        }

    }
}