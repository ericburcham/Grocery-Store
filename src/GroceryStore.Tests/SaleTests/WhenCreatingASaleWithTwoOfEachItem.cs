using System.Linq;

using FluentAssertions;
using GroceryStore.Inventory;
using NUnit.Framework;

namespace GroceryStore.Tests.SaleTests
{
    [TestFixture]
    public class WhenCreatingASaleWithTwoOfEachItem
    {
        private Sale _sale;

        [OneTimeSetUp]
        internal void OneTimeSetUp()
        {
            _sale = new Sale(null, new ItemBuilder());
            _sale.AddItem("1245");
            _sale.AddItem("1245");

            _sale.AddItem("99999");
            _sale.AddItem("99999");

            _sale.AddItem("839");
            _sale.AddItem("839");
        }

        [Test]
        public void SaleTotalShouldBeCorrect()
        {
            const decimal priceForTwoOfEachItem = 2 * (1.25M + 4.88M + 10M);
            _sale.Total.Should().Be(priceForTwoOfEachItem);
        }

        [Test]
        public void ThereShouldBeThreeLineItems()
        {
            _sale.LineItems.Count.Should().Be(3);
        }
    }
}