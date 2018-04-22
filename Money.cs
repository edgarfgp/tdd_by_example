namespace MoneyTests
{
    public class Money
    {
        protected int amount { get; set; }

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