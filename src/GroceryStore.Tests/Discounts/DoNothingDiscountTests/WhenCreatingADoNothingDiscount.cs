﻿using FluentAssertions;
using GroceryStore.Discounts;
using NUnit.Framework;

namespace GroceryStore.Tests.Discounts.DoNothingDiscountTests
{
    [TestFixture]
    public class WhenCreatingADoNothingDiscount
    {
        private decimal _discount;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _discount = new DoNothingDiscount().GetDiscount(100, 100M);
        }

        [Test]
        public void TheDiscountShouldBeCorrect()
        {
            _discount.Should().Be(0M);
        }
    }
}