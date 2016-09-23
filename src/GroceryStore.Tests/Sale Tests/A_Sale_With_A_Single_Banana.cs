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
    }
}