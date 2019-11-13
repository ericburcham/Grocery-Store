using System.Collections.Generic;
using System.Linq;
using GroceryStore.Discounts;
using GroceryStore.Inventory;

namespace GroceryStore
{
    public class Sale
    {
        private readonly IManageDiscounts _discountManager;

        private readonly IBuildItems _itemBuilder;

        public Sale(IManageDiscounts discountManager, IBuildItems itemBuilder)
        {
            _discountManager = discountManager;
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
                var itemDiscount = _discountManager.GetDiscount(sku);
                var lineItem = new LineItem(item, itemDiscount);
                LineItems.Add(lineItem);
            }
        }
    }
}