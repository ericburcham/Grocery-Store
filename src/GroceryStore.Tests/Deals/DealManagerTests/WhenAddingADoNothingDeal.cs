using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using GroceryStore.Deals;
using NUnit.Framework;

namespace GroceryStore.Tests.Deals.DealManagerTests
{
    [TestFixture]
    public class WhenAddingADoNothingDeal
    {
        private DealManager _dealManager;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _dealManager = new DealManager();
            _dealManager.AddDeal("sku", new DoNothingDeal());
        }

        [Test]
        public void GetDealShouldReturnTheCorrectDeal()
        {
            _dealManager.GetDeal("sku").Should().BeOfType<DoNothingDeal>();
        }
    }
}
