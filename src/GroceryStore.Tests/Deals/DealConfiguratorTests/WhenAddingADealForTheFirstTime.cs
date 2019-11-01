using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using GroceryStore.Deals;
using NUnit.Framework;

namespace GroceryStore.Tests.Deals.DealConfiguratorTests
{
    [TestFixture]
    public class WhenAddingADealForTheFirstTime
    {
        const string SKU = "sku";

        private IConfigureDeals _dealConfigurator;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _dealConfigurator = new DealConfigurator();
            _dealConfigurator.AddDeal(SKU, new DollarOffDeal());
        }

        [Test]
        public void GetDealShouldReturnTheCorrectDeal()
        {
            _dealConfigurator.GetDeal(SKU).Should().BeOfType<DollarOffDeal>();
        }
    }
}
