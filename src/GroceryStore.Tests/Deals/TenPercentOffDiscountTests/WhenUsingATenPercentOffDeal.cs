using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using GroceryStore.Deals;
using NUnit.Framework;

namespace GroceryStore.Tests.Deals.TenPercentOffDiscountTests
{
    [TestFixture]
    public class WhenUsingATenPercentOffDeal
    {
        private decimal _discount;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            var deal = new TenPercentOffDeal();
            _discount = deal.GetDiscount(1, 10);
        }

        [Test]
        public void TheDiscountShouldBeCorrect()
        {
            _discount.Should().Be(1);
        }
    }
}
