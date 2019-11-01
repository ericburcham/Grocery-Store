using FluentAssertions;
using GroceryStore.Deals;
using NUnit.Framework;

namespace GroceryStore.Tests.Deals.DollarOffDealTests
{
    [TestFixture]
    public class WhenQuantityIsTwoAndPriceIsTwoDollars
    {
        private decimal _discount;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _discount = new DollarOffDeal().GetDiscount(2, 2M);
        }

        [Test]
        public void DiscountShouldBeOneDollar()
        {
            _discount.Should().Be(2M);
        }
    }
}