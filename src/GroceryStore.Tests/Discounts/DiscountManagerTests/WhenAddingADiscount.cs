using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentAssertions;
using GroceryStore.Discounts;
using NSubstitute;
using NUnit.Framework;

namespace GroceryStore.Tests.Discounts.DiscountManagerTests
{
    [TestFixture]
    public class WhenAddingADiscount
    {
        private IManageDiscounts _discountManager;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _discountManager = new DiscountManager();
            _discountManager.AddDiscount("sku", new DoNothingDiscount());
        }

        [Test]
        public void GetDiscountShouldReturnTheSameTypeOfDiscountThatWasAdded()
        {
            _discountManager.GetDiscount("sku").Should().BeOfType<DoNothingDiscount>();
        }
    }
}
