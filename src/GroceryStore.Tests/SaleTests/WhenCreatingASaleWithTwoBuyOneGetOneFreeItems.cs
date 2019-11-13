using FluentAssertions;
using GroceryStore.Discounts;
using GroceryStore.Inventory;
using NUnit.Framework;

namespace GroceryStore.Tests.SaleTests
{
    [TestFixture]
    public class WhenCreatingASaleWithTwoBuyOneGetOneFreeItems
    {
        private IManageDiscounts _discountManager;
        private readonly ItemBuilder _itemBuilder = new ItemBuilder();
        private Sale _sale;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            _discountManager = new DiscountManager();
            _discountManager.AddDiscount("1245", new BuyTwoGetOneFreeDiscount());
            _sale = new Sale(_discountManager, _itemBuilder);
            _sale.AddItem("1245");
            _sale.AddItem("1245");
        }

        [Test]
        public void TheSaleTotalShouldBeOneDollarLessThanTheItemPrice()
        {
            var bananas = _itemBuilder.BuildItem("1245");
            var priceOfBananas = bananas.Price;
            var expectedSaleTotal = priceOfBananas;
            _sale.Total.Should().Be(expectedSaleTotal);
        }
    }
}