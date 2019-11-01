using System;
using System.Collections.Generic;
using System.Text;
using FluentAssertions;
using GroceryStore.Deals;
using NSubstitute;
using NUnit.Framework;

namespace GroceryStore.Tests.LineItemTests
{
    [TestFixture]
    public class WhenALineItemHasAQuantityOfOneWithADeal
    {
        private LineItem _lineItem;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            var deal = Substitute.For<IDeal>();
            deal.GetDiscount(Arg.Any<uint>(), Arg.Any<decimal>()).Returns(1);

            var dealManager = Substitute.For<IManageDeals>();
            dealManager.GetDeal(Arg.Any<string>()).Returns(deal);

            var item = new Item("1245", "Item", 2);
            _lineItem = new LineItem(item, dealManager);
        }

        [Test]
        public void TheSubtotalShouldBeCorrect()
        {
            _lineItem.Subtotal.Should().Be(1);
        }

        [Test]
        public void TheDiscountShouldBeCorrect()
        {
            _lineItem.Discount.Should().Be(1);
        }

        [Test]
        public void TheRawTotalShouldBeCorrect()
        {
            _lineItem.RawTotal.Should().Be(2);
        }
    }
}
