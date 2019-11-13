using GroceryStore.Discounts;

namespace GroceryStore
{
    public class LineItem
    {
        private readonly IProvideDiscounts _discountProvider;

        public LineItem(Item item, IProvideDiscounts discountProvider = null)
        {
            _discountProvider = discountProvider ?? new DoNothingDiscountProvider();

            Item = item;
            AddOne();
        }

        private Item Item { get; }

        public uint Quantity { get; private set; }

        public decimal RawTotal => Quantity * Item.Price;

        public string Sku => Item.Sku;

        public string Name => Item.Name;

        public decimal Price => Item.Price;

        public decimal Discount => _discountProvider.GetDiscount(Sku, Quantity, Price);

        public decimal Subtotal => RawTotal - Discount;

        public void AddOne()
        {
            Quantity += 1;
        }
    }
}