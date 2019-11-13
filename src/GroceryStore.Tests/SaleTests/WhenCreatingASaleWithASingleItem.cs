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
        private IManageDiscountProviders _discountProviderManager;

        private Sale _sale;

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _discountProviderManager = Substitute.For<IManageDiscountProviders>();
            var discount = Substitute.For<IProvideDiscounts>();
            _discountProviderManager.GetDiscount(Arg.Any<string>()).Returns(discount);

            _sale = new Sale(_discountProviderManager, new ItemBuilder());
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
            _discountProviderManager.Received(1).GetDiscount("1245");
        }
    }
}