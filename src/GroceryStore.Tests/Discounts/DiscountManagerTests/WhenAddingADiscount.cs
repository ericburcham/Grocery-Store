using FluentAssertions;
using GroceryStore.Discounts;
using NUnit.Framework;

namespace GroceryStore.Tests.Discounts.DiscountManagerTests
{
    [TestFixture]
    public class WhenAddingADiscount
    {
        private IManageDiscounts _discountManager;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _discountManager = new DiscountManager();
            _discountManager.AddDiscount("sku", new DoNothingDiscount());
        }

        [Test]
        public void GetDiscountShouldReturnTheSameTypeOfDiscountThatWasAdded()
        {
            _discountManager.GetDiscount("sku", 1, 0M).Should().Be(0);
        }
    }
}
