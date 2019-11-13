using FluentAssertions;
using GroceryStore.Discounts;
using GroceryStore.Inventory;
using NUnit.Framework;

namespace GroceryStore.Tests.SaleTests
{
    [TestFixture]
    public class WhenCreatingASaleWithADollarOffItem
    {
        private IManageDiscounts _discountManager;
        private ItemBuilder _itemBuilder = new ItemBuilder();
        private Sale _sale;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            _discountManager = new DiscountManager();   
            _discountManager.AddDiscount("1245", new DollarOffDiscount());
            _sale = new Sale(_discountManager, _itemBuilder);
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
