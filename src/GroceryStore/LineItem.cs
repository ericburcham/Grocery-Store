using GroceryStore.Deals;

namespace GroceryStore
{
    public class LineItem
    {
        private readonly IDeal _deal;

        public LineItem(Item item, IManageDeals dealManager)
        {
            Item = item;
            _deal = dealManager.GetDeal(item.Sku);
            AddOne();
        }

        private Item Item { get; }

        public uint Quantity { get; private set; }

        public decimal RawTotal => Quantity * Item.Price;

        public string Sku => Item.Sku;

        public string Name => Item.Name;

        public decimal Price => Item.Price;

        public decimal Discount => _deal.GetDiscount(Quantity, Price);

        public decimal Subtotal => RawTotal - Discount;

        public void AddOne()
        {
            Quantity += 1;
        }
    }
}