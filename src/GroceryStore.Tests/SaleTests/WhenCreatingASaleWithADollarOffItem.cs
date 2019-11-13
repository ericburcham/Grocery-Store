using FluentAssertions;
using GroceryStore.Discounts;
using GroceryStore.Inventory;
using NUnit.Framework;

namespace GroceryStore.Tests.SaleTests
{
    [TestFixture]
    public class WhenCreatingASaleWithADollarOffItem
    {
        private IManageDiscountProviders _discountProviderManager;
        private readonly ItemBuilder _itemBuilder = new ItemBuilder();
        private Sale _sale;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            _discountProviderManager = new DiscountProviderManager();   
            _discountProviderManager.AddDiscount("1245", new DollarOffDiscount());
            _sale = new Sale(_discountProviderManager, _itemBuilder);
            _sale.AddItem("1245");
        }

        [Test]
        public void TheSaleTotalShouldBeOneDollarLessThanTheItemPrice()
        {
            var bananas = _itemBuilder.BuildItem("1245");
            var priceOfBananas = bananas.Price;
            var expectedSaleTotal = priceOfBananas - 1M;
            _sale.Total.Should().Be(expectedSaleTotal);
        }
    }
}
