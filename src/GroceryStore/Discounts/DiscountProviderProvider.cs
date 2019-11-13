using System;
using System.Collections.Generic;

namespace GroceryStore.Discounts
{
    public class DiscountProviderProvider : IProvideDiscountProviders
    {
        public DiscountProviderProvider()
        {
            DiscountProviders = new Dictionary<string, IProvideDiscounts>();
        }

        protected Dictionary<string, IProvideDiscounts> DiscountProviders { get; set; }

        public IProvideDiscounts GetDiscount(string sku)
        {
            if (DiscountProviders.ContainsKey(sku))
            {
                return DiscountProviders[sku];
            }

            throw new NotImplementedException();
        }
    }
}