using FluentAssertions;
using GroceryStore.Inventory;
using NUnit.Framework;

namespace GroceryStore.Tests.Inventory.ItemBuilderTests
{
    [TestFixture]
    public class WhenBuildingPeptoBismol
    {
        private Item _item;
        
        private ItemBuilder _itemBuilder;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _itemBuilder = new ItemBuilder();
            _item = _itemBuilder.BuildItem("99999");
        }

        [Test]
        public void NameShouldBeCorrect()
        {
            _item.Name.Should().Be("Pepto Bismol");
        }

        [Test]
        public void PriceShouldBeCorrect()
        {
            _item.Price.Should().Be(4.88M);
        }

        [Test]
        public void SkuShouldBeCorrect()
        {
            _item.Sku.Should().Be("99999");
        }
    }
}