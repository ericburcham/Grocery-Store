using System.Collections.Generic;

namespace GroceryStore
{
    public class Sale
    {
        public void AddItem(string s)
        {
            var item = new Item(s, "Bananas", 1.25M);
            LineItems.Add(new LineItem(item));
        }

        public List<LineItem> LineItems { get; set; } = new List<LineItem>();
    }

    public class LineItem
    {
        public LineItem(Item item)
        {
            Sku = item.Sku;
            Name = item.Name;
            Quantity = 1;
            Price = item.Price;
        }

        public string Sku { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal RawTotal { get; set; }

        public void IncrementQuantity()
        {
            Quantity += 1;
        }
    }

    public class Item
    {
        public string Sku { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Item(string sku, string name, decimal price)
        {
            Sku = sku;
            Name = name;
            Price = price;
        }
    }
}