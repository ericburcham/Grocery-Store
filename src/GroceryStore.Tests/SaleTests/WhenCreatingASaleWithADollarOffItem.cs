using FluentAssertions;
using GroceryStore.Inventory;
using NUnit.Framework;

namespace GroceryStore.Tests.SaleTests
{
    [TestFixture]
    public class WhenCreatingASaleWithADollarOffItem
    {
        private IManageDeals _dealManager;
        private Sale _sale;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            _dealManager = new DealManager();
            _dealManager.AddDeal("1245", new DollarOffDeal());
            _sale = new Sale(_dealManager, new ItemBuilder());
            _sale.AddItem("1245");
        }

        [Test]
        public void TheSaleTotalShouldBeOneDollarLessThanTheItemPrice()
        {
            var itemBuilder = new ItemBuilder();
            var bananas = itemBuilder.BuildItem("1245");
            var priceOfBananas = bananas.Price;
            var expectedSaleTotal = priceOfBananas - 1M;
            _sale.Total.Should().Be(expectedSaleTotal);
        }
    }
}
