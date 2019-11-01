using FluentAssertions;
using GroceryStore.Inventory;
using NUnit.Framework;

namespace GroceryStore.Tests.Inventory.ItemBuilderTests
{
    [TestFixture]
    public class WhenBuildingRubberBands
    {
        private Item _item;
        
        private ItemBuilder _itemBuilder;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _itemBuilder = new ItemBuilder();
            _item = _itemBuilder.BuildItem("839");
        }

        [Test]
        public void NameShouldBeCorrect()
        {
            _item.Name.Should().Be("Rubber Bands");
        }

        [Test]
        public void PriceShouldBeCorrect()
        {
            _item.Price.Should().Be(10M);
        }

        [Test]
        public void SkuShouldBeCorrect()
        {
            _item.Sku.Should().Be("839");
        }
    }
}