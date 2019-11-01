using FluentAssertions;
using GroceryStore.Inventory;
using NUnit.Framework;

namespace GroceryStore.Tests.SaleTests
{
    [TestFixture]
    public class WhenCreatingASaleWithASingleItem
    {
        private Sale _sale;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _sale = new Sale(new ItemBuilder());
            _sale.AddItem("1245");
        }

        [Test]
        public void SaleTotalShouldBeCorrect()
        {
            _sale.Total.Should().Be(1.25M);
        }

        [Test]
        public void ThereShouldBeOneLineItem()
        {
            _sale.LineItems.Count.Should().Be(1);
        }
    }
}