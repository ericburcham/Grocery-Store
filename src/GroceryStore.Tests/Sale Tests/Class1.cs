using System.Linq;
using FluentAssertions;
using NUnit.Framework;

namespace GroceryStore.Tests
{
    [TestFixture]
    class A_Sale_With_Two_Banana
    {
        private Sale _sale;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _sale = new Sale();
            _sale.AddItem("1245");
            _sale.AddItem("1245");
        }

        [Test]
        public void There_Should_Only_Be_One_LineItem()
        {
            _sale.LineItems.Count.Should().Be(1);
        }

        [Test]
        public void There_Should_Be_Two_Bananas()
        {
            LineItem lineItem = _sale.LineItems.Single();
            lineItem.Quantity.Should().Be(2);
        }
    }

    [TestFixture]
    public class An_Existing_LineItem_Add_Quantity
    {
        private LineItem _lineItem;

        [OneTimeSetUp]
        public void Setup()
        {
            var item = new Item("1245", "Banana", 1.25M);
            _lineItem = new LineItem(item);
            _lineItem.IncrementQuantity();
        }

        [Test]
        public void There_Should_Be_Two_Quantity()
        {
            _lineItem.Quantity.Should().Be(2);
            _lineItem.RawTotal.Should().Be(2.50m);
        }
    }
}