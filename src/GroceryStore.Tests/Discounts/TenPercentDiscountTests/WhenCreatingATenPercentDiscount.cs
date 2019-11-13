using FluentAssertions;
using GroceryStore.Discounts;
using NUnit.Framework;

namespace GroceryStore.Tests.Discounts.TenPercentDiscountTests
{
    [TestFixture]
    public class WhenCreatingATenPercentDiscount
    {
        private const int QUANTITY = 100;
        private const decimal PRICE = 100M;

        private decimal _discount;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _discount = new TenPercentDiscount().GetDiscount(QUANTITY, PRICE);
        }

        [Test]
        public void TheDiscountShouldBeCorrect()
        {
            _discount.Should().Be(QUANTITY * PRICE * 0.1M);
        }
    }
};