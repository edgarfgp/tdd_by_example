using NUnit.Framework;

namespace MoneyTests
{
    [TestFixture]
    public class MoneyTests
    {

        [Test]
        public void TestMultiplication()
        {
            Money five = new Money(5);
            Money product = five.Times(2);
            Assert.AreEqual(10, five.amount);

            product = five.Times(3);
            // Assert.AreEqual(15, product.amount);
        }

        [Test]
        public void TestEquality()
        {
            Assert.True(new Money(5).Equals(new Money(5)));
            Assert.False(new Money(5).Equals(new Money(6)));
        }
    }
}