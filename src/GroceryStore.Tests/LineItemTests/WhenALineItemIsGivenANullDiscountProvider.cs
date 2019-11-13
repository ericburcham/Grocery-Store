using FluentAssertions;
using GroceryStore.Discounts;
using NSubstitute;
using NUnit.Framework;

namespace GroceryStore.Tests.LineItemTests
{
    [TestFixture]
    public class WhenALineItemIsGivenANullDiscountProvider
    {
        private LineItem _lineItem;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _lineItem = new LineItem(new Item("sku", "I don't matter one bit", 1.25M));
        }

        [Test]
        public void TheRawTotalShouldBeCorrect()
        {
            _lineItem.RawTotal.Should().Be(_lineItem.Quantity * _lineItem.Price);
        }

        [Test]
        public void TheDiscountShouldBeCorrect()
        {
            _lineItem.Discount.Should().Be(0M);
        }

        [Test]
        public void TheSubtotalShouldBeCorrect()
        {
            _lineItem.Subtotal.Should().Be(_lineItem.RawTotal);
        }
    }
}
