using System;

namespace GroceryStore.Discounts
{
    internal class DoNothingDiscountProvider : IProvideDiscounts
    {
        public decimal GetDiscount(string sku, uint quantity, decimal price)
        {
            return new DoNothingDiscount().GetDiscount(quantity, price);
        }
    }
}