using FluentAssertions;
using NUnit.Framework;

namespace GroceryStore.Tests.LineItemTests
{
    [TestFixture]
    public class WhenALineItemIsInstantiatedWithTheParameterizedConstructor
    {
        private Item _item;

        private LineItem _lineItem;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _item = new Item("sku", "name", 1M);
            _lineItem = new LineItem(_item);
        }

        [Test]
        public void NameShouldBeTheItemName()
        {
            _lineItem.Name.Should().Be(_item.Name);
        }

        [Test]
        public void PriceShouldBeTheItemPrice()
        {
            _lineItem.Price.Should().Be(_item.Price);
        }

        [Test]
        public void SkuShouldBeTheItemSku()
        {
            _lineItem.Sku.Should().Be(_item.Sku);
        }
    }
}