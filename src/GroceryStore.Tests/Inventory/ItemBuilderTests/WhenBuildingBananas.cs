using FluentAssertions;
using GroceryStore.Inventory;
using NUnit.Framework;

namespace GroceryStore.Tests.Inventory.ItemBuilderTests
{
    [TestFixture]
    public class WhenBuildingBananas
    {
        private Item _item;

        private ItemBuilder _itemBuilder;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _itemBuilder = new ItemBuilder();
            _item = _itemBuilder.BuildItem("1245");
        }

        [Test]
        public void NameShouldBeCorrect()
        {
            _item.Name.Should().Be("Bananas");
        }

        [Test]
        public void PriceShouldBeCorrect()
        {
            _item.Price.Should().Be(1.25M);
        }

        [Test]
        public void SkuShouldBeCorrect()
        {
            _item.Sku.Should().Be("1245");
        }
    }
}