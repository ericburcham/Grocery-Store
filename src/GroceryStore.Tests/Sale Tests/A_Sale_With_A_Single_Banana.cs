using System.Linq;
using FluentAssertions;
using NUnit.Framework;

namespace GroceryStore.Tests
{
    [TestFixture]
    class A_Sale_With_A_Single_Banana
    {
        private Sale _sale;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _sale = new Sale();
            _sale.AddItem("1245");
        }

        [Test]
        public void There_Should_Only_Be_One_LineItem()
        {
            _sale.LineItems.Count.Should().Be(1);
        }

        [Test]
        public void The_Line_Item_Should_Be_A_Banana()
        {
            LineItem lineItem = _sale.LineItems.Single();
            lineItem.Sku.Should().Be("1245");
            lineItem.Name.Should().Be("Bananas");
            lineItem.Price.Should().Be(1.25M);
            lineItem.Quantity.Should().Be(1);
            lineItem.RawTotal.Should().Be(1.25M);
        }
    }
}