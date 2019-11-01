using FluentAssertions;
using NUnit.Framework;

namespace GroceryStore.Tests.ItemTests
{
    [TestFixture]
    public class WhenCreatingAnItemWithTheParameterizedConstructor
    {
        private const string ITEM_NAME = "name";

        private const decimal ITEM_PRICE = 1M;

        private const string ITEM_SKU = "sku";

        private Item _item;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _item = new Item(ITEM_SKU, ITEM_NAME, ITEM_PRICE);
        }

        [Test]
        public void NameShouldBeCorrect()
        {
            _item.Name.Should().Be(ITEM_NAME);
        }

        [Test]
        public void PriceShouldBeCorrect()
        {
            _item.Price.Should().Be(ITEM_PRICE);
        }

        [Test]
        public void SkuShouldBeCorrect()
        {
            _item.Sku.Should().Be(ITEM_SKU);
        }
    }
}