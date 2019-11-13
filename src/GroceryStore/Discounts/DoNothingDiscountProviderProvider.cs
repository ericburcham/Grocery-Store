using System;

namespace GroceryStore.Discounts
{
    internal class DoNothingDiscountProviderProvider : IProvideDiscountProviders
    {
        public IProvideDiscounts GetDiscount(string sku)
        {
            return new DoNothingDiscount();
        }
    }
}