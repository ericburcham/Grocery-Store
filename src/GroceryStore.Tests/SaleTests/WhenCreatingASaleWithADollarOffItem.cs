using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using NUnit.Framework;

namespace GroceryStore.Tests.SaleTests
{
    [TestFixture]
    class WhenCreatingASaleWithADollarOffItem
    {
        private IConfigureDeals _dealConfigurator;
        private Sale _sale;

        [OneTimeSetUp]
        private void OneTimeSetup()
        {
            _dealConfigurator = new DealConfigurator();
            _dealConfigurator.AddDeal("1245", new DollarOffDeal());
            _sale = new Sale(_dealConfigurator, new ItemBuilder());
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
