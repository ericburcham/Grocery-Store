using FluentAssertions;
using GroceryStore.Discounts;
using GroceryStore.Inventory;
using NSubstitute;
using NUnit.Framework;

namespace GroceryStore.Tests.SaleTests
{
    [TestFixture]
    public class WhenCreatingASaleWithASingleItem
    {
        private IManageDiscounts _discountManager;

        private Sale _sale;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _discountManager = Substitute.For<IManageDiscounts>();
            var discount = Substitute.For<IProvideDiscounts>();
            _discountManager.GetDiscount(Arg.Any<string>()).Returns(discount);

            _sale = new Sale(_discountManager, new ItemBuilder());
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

        [Test]
        public void GetDiscountShouldBeInvokedOnTheDiscountManager()
        {
            _discountManager.Received(1).GetDiscount("1245");
        }
    }
}