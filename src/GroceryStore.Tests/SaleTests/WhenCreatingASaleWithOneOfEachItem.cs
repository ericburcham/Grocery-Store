using System.Linq;

using FluentAssertions;

using NUnit.Framework;

namespace GroceryStore.Tests.SaleTests
{
    [TestFixture]
    public class WhenCreatingASaleWithOneOfEachItem
    {
        private Sale _sale;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _sale = new Sale(new ItemBuilder());
            _sale.AddItem("1245");
            _sale.AddItem("99999");
            _sale.AddItem("839");
        }

        [Test]
        public void SaleTotalShouldBeCorrect()
        {
            const decimal saleTotalForOneOfEachItem = 1.25M + 4.88M + 10M;
            _sale.Total.Should().Be(saleTotalForOneOfEachItem);
        }

        [Test]
        public void ThereShouldBeThreeLineItems()
        {
            _sale.LineItems.Count.Should().Be(3);
        }
    }
}