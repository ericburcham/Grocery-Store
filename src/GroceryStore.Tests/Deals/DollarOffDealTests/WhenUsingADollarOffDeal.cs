using System.Runtime.InteropServices;
using FluentAssertions;
using GroceryStore.Deals;
using NUnit.Framework;

namespace GroceryStore.Tests.Deals.DollarOffDealTests
{
    [TestFixture]
    public class WhenUsingADollarOffDeal
    {
        private decimal _discount;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            var deal  = new DollarOffDeal();
            _discount = deal.GetDiscount(1, 2);
        }

        [Test]
        public void TheDiscountShouldBeCorrect()
        {
            _discount.Should().Be(1);
        }
    }
}