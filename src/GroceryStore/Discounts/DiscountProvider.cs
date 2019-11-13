using System.Collections.Generic;

namespace GroceryStore.Discounts
{
    public class DiscountProvider : IProvideDiscounts
    {
        public DiscountProvider()
        {
            ConfiguredDiscounts = new Dictionary<string, IDiscountStrategy>();
        }

        public Dictionary<string, IDiscountStrategy> ConfiguredDiscounts { get; }

        public decimal GetDiscount(string sku, uint quantity, decimal price)
        {
            var strategy = ConfiguredDiscounts.ContainsKey(sku)
                ? ConfiguredDiscounts[sku]
                : new DoNothingDiscount();

            return strategy.GetDiscount(quantity, price);
        }
    }
}