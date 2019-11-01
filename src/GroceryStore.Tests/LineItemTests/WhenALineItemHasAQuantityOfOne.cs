using FluentAssertions;
using NUnit.Framework;

namespace GroceryStore.Tests.LineItemTests
{
    [TestFixture]
    public class WhenALineItemHasAQuantityOfOne
    {
        private LineItem _lineItem;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            var item = new Item("sku", "name", 1);
            _lineItem = new LineItem(item, null);
        }

        [Test]
        public void TheQuantityShouldBeOne()
        {
            _lineItem.Quantity.Should().Be(1);
        }

        [Test]
        public void TheRawTotalShouldBeCorrect()
        {
            var expectedRawTotal = _lineItem.Price * _lineItem.Quantity;
            _lineItem.RawTotal.Should().Be(expectedRawTotal);
        }
    }
}