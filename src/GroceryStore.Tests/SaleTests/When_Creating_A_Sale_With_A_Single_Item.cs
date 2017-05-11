using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using NUnit.Framework;
using ProductData;

namespace GroceryStore.Tests.SaleTests
{
    [TestFixture]
    public class When_Creating_A_Sale_With_A_Single_Item
    {
        private LineItem _lineItem;

        private string _productSku;

        private string _productDescription;

        private decimal _productPrice;

        private Sale _sale;


        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            var productDataProvider = new ProductDataProvider();

            GetProductionData(productDataProvider);

            _sale = new Sale();
            _sale.AddItem("1245");
            _lineItem = _sale.LineItems.Single();
        }

        [Test]
        public void The_LineItem_Price_Should_Be_Correct()
        {
            _lineItem.Price.Should().Be(_productPrice);
        }

        private void GetProductionData(ProductDataProvider productDataProvider)
        {
            var productData = productDataProvider.GetProductData("1245");
            _productSku = productData[0];
            _productDescription = productData[1];
            _productPrice = decimal.Parse(productData[2]);
        }
    }
}
