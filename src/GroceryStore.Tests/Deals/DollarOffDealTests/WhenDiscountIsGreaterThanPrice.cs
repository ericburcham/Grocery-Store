using System;
using FluentAssertions;
using GroceryStore.Deals;
using NUnit.Framework;

namespace GroceryStore.Tests.Deals.DollarOffDealTests
{
    [TestFixture]
    public class WhenDiscountIsGreaterThanPrice
    {
        private DollarOffDeal _dollarOffDeal;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _dollarOffDeal = new DollarOffDeal();
        }

        [Test]
        public void Invoking_Get_Discount_Throws_An_InvalidOperationException()
        {
            Action tryingToGetDiscountForPriceLessThanOneDollar = () => _dollarOffDeal.GetDiscount(1, 0.5M);
            tryingToGetDiscountForPriceLessThanOneDollar.Should().Throw<InvalidOperationException>()
                .WithMessage("We're not in the business of giving away merchandise.");
        }
    }
}