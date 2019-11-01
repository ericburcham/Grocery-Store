using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using GroceryStore.Deals;
using NUnit.Framework;

namespace GroceryStore.Tests.Deals.DollarOffDealTests
{
    [TestFixture]
    public class WhenQuantityIsOneAndPriceIsTwoDollars
    {
        private decimal _discount;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _discount = new DollarOffDeal().GetDiscount(1, 2M);
        }

        [Test]
        public void DiscountShouldBeOneDollar()
        {
            _discount.Should().Be(1M);
        }
    }
}
