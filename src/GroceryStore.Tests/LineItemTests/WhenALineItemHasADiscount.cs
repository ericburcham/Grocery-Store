using FluentAssertions;
using GroceryStore.Discounts;
using NSubstitute;
using NUnit.Framework;

namespace GroceryStore.Tests.LineItemTests
{
    [TestFixture]
    public class WhenALineItemHasADiscount
    {
        private const decimal DISCOUNT = 0.10M;

        private LineItem _lineItem;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            var discountProvider = Substitute.For<IProvideDiscounts>();
            discountProvider.GetDiscount(Arg.Any<string>(), Arg.Any<uint>(), Arg.Any<decimal>()).Returns(DISCOUNT);

            _lineItem = new LineItem(new Item("sku", "I don't matter one bit", 1.25M), discountProvider);
        }

        [Test]
        public void TheDiscountShouldBeCorrect()
        {
            _lineItem.Discount.Should().Be(DISCOUNT);
        }

        [Test]
        public void TheRawTotalShouldBeCorrect()
        {
            _lineItem.RawTotal.Should().Be(_lineItem.Quantity * _lineItem.Price);
        }

        [Test]
        public void TheSubtotalShouldBeCorrect()
        {
            _lineItem.Subtotal.Should().Be(_lineItem.RawTotal - DISCOUNT);
        }
    }
}