using System;
using System.Collections.Generic;

namespace GroceryStore.Deals
{
    public class DealManager : IManageDeals
    {
        private readonly Dictionary<string, IDeal> ActiveDeals = new Dictionary<string, IDeal>(StringComparer.Ordinal);

        public void AddDeal(string sku, IDeal deal)
        {
            ActiveDeals.Add(sku, deal);
        }

        public IDeal GetDeal(string sku)
        {
            if (ActiveDeals.ContainsKey(sku))
                return ActiveDeals[sku];
            else
                return new DoNothingDeal();
        }
    }
}