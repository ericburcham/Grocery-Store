using System;
using System.Collections.Generic;

namespace GroceryStore.Discounts
{
    public class DiscountManager : IManageDiscounts
    {
        private IDictionary<string, IProvideDiscounts> _discounts;

        public DiscountManager()
        {
            _discounts = new Dictionary<string, IProvideDiscounts>();
        }

        public void AddDiscount(string sku, IProvideDiscounts discount)
        {
            _discounts.Add(sku, discount);
        }

        public IProvideDiscounts GetDiscount(string sku)
        {
            if (_discounts.ContainsKey(sku))
            {
                return _discounts[sku];
            }

            throw new NotImplementedException();
        }
    }
}
