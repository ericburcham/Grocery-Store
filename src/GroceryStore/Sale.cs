using System.Collections.Generic;
using System.Linq;
using GroceryStore.Deals;
using GroceryStore.Inventory;

namespace GroceryStore
{
    public class Sale
    {
        private readonly IManageDeals _dealManager;
        private readonly IBuildItems _itemBuilder;

        public Sale(IManageDeals dealManager, IBuildItems itemBuilder)
        {
            _dealManager = dealManager;
            _itemBuilder = itemBuilder;
            LineItems = new List<LineItem>();
        }

        public IList<LineItem> LineItems { get; }

        public decimal Total => LineItems.Sum(item => item.RawTotal);

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
                var lineItem = new LineItem(item, _dealManager);
                LineItems.Add(lineItem);
            }
        }
    }
}