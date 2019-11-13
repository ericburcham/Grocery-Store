using FluentAssertions;
using GroceryStore.Discounts;
using NUnit.Framework;

namespace GroceryStore.Tests.Discounts.DiscountManagerTests
{
    [TestFixture]
    public class WhenAddingADiscount
    {
        private IManageDiscountProviders _discountProviderManager;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _discountProviderManager = new DiscountProviderManager();
            _discountProviderManager.AddDiscount("sku", new DoNothingDiscount());
        }

        [Test]
        public void GetDiscountShouldReturnTheSameTypeOfDiscountThatWasAdded()
        {
            _discountProviderManager.GetDiscount("sku").Should().BeOfType<DoNothingDiscount>();
        }
    }
}
