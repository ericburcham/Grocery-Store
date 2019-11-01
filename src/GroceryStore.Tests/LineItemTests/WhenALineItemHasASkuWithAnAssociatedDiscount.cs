using FluentAssertions;
using GroceryStore.Deals;
using GroceryStore.Inventory;
using NSubstitute;
using NUnit.Framework;

namespace GroceryStore.Tests.LineItemTests
{
    [TestFixture]
    public class WhenALineItemHasASkuWithAnAssociatedDiscount
    {
        private const decimal EXPECTED_DISCOUNT = 1.25M;

        private LineItem _lineItem;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            var substituteDeal = Substitute.For<IDeal>();
            substituteDeal.GetDiscount(Arg.Any<uint>(), Arg.Any<decimal>()).Returns(EXPECTED_DISCOUNT);

            var substituteDealProvider = Substitute.For<IProvideDeals>();
            substituteDealProvider.GetDeal(Arg.Any<string>()).Returns(substituteDeal);

            var itemBuilder = new ItemBuilder();
            var item = itemBuilder.BuildItem("1245");
            _lineItem = new LineItem(item, substituteDealProvider);
        }

        [Test]
        public void DiscountShouldBeCorrect()
        {
            _lineItem.Discount.Should().Be(EXPECTED_DISCOUNT);
        }

        [Test]
        public void QuantityShouldBeCorrect()
        {
            _lineItem.Quantity.Should().Be(1);
        }

        [Test]
        public void SubtotalShouldBeRawTotalMinusDiscount()
        {
            _lineItem.Subtotal.Should().Be(_lineItem.RawTotal - _lineItem.Discount);
        }
    }
}