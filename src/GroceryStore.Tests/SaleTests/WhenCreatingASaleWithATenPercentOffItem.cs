using FluentAssertions;
using GroceryStore.Deals;
using GroceryStore.Inventory;
using NUnit.Framework;

namespace GroceryStore.Tests.SaleTests
{
    [TestFixture]
    public class WhenCreatingASaleWithATenPercentOffItem
    {
        private IManageDeals _dealManager;
        private Sale _sale;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {
            _dealManager = new DealManager();
            _dealManager.AddDeal("839", new TenPercentOffDeal());
            _sale = new Sale(_dealManager, new ItemBuilder());
            _sale.AddItem("839");
        }

        [Test]
        public void TheSaleTotalShouldBeOneDollarLessThanTheItemPrice()
        {
            var itemBuilder = new ItemBuilder();
            var rubberBands = itemBuilder.BuildItem("839");
            var priceOfRubberBands = rubberBands.Price;
            var expectedSaleTotal = priceOfRubberBands - 1M;
            _sale.Total.Should().Be(expectedSaleTotal);
        }
    }
}