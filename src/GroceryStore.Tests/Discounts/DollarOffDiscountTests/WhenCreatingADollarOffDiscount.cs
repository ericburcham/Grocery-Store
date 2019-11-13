using FluentAssertions;
using GroceryStore.Discounts;
using NUnit.Framework;

namespace GroceryStore.Tests.Discounts.DollarOffDiscountTests
{
    [TestFixture]
    public class WhenCreatingADollarOffDiscount
    {
        private const int QUANTITY = 100;

        private decimal _discount;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _discount = new DollarOffDiscount().GetDiscount(QUANTITY, 100M);
        }

        [Test]
        public void TheDiscountShouldBeCorrect()
        {
            _discount.Should().Be(QUANTITY);
        }
    }
}
