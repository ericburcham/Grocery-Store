using FluentAssertions;
using GroceryStore.Discounts;
using GroceryStore.Inventory;
using NUnit.Framework;

namespace GroceryStore.Tests.SaleTests
{
    [TestFixture]
    public class WhenCreatingASaleWithATenPercentDiscount
    {
        private IManageDiscounts _discountProviderManager;
        private readonly ItemBuilder _itemBuilder = new ItemBuilder();
        private Sale _sale;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            _discountProviderManager = new DiscountManager();   
            _discountProviderManager.AddDiscount("839", new TenPercentDiscount());
            _sale = new Sale(_discountProviderManager, _itemBuilder);
            _sale.AddItem("839");
        }

        [Test]
        public void TheSaleTotalShouldBeCorrect()
        {
            var rubberBands = _itemBuilder.BuildItem("839");
            var priceOfRubberBands = rubberBands.Price;
            var expectedSaleTotal = priceOfRubberBands * 0.9M;
            _sale.Total.Should().Be(expectedSaleTotal);
        }
    }
}
