using System.Collections.Generic;
using System.Linq;
using GroceryStore.Discounts;
using GroceryStore.Inventory;

namespace GroceryStore
{
    public class Sale
    {
        private readonly IProvideDiscounts _discountProvider;

        private readonly IBuildItems _itemBuilder;

        public Sale(IProvideDiscounts discountProvider, IBuildItems itemBuilder)
        {
            _discountProvider = discountProvider ?? new DoNothingDiscountProvider();
            _itemBuilder = itemBuilder;
            LineItems = new List<LineItem>();
        }

        public IList<LineItem> LineItems { get; }

        public decimal Total => LineItems.Sum(item => item.Subtotal);

        public void AddItem(string sku)
        {
            var existingItem = LineItems.SingleOrDefault(lineItem => lineItem.Sku == sku);

            if (existingItem != null)
            {
                existingItem.AddOne();
            }
            else
            {
                var item = _itemBuilder.BuildItem(sku);
                var lineItem = new LineItem(item, _discountProvider);
                LineItems.Add(lineItem);
            }
        }
    }
}