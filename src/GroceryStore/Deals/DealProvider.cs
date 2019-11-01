using System.Collections.Generic;

namespace GroceryStore.Deals
{
    public class DealProvider : IProvideDeals
    {
        protected readonly Dictionary<string, IDeal> Deals;

        protected DealProvider()
        {
            Deals = new Dictionary<string, IDeal>();
        }

        public IDeal GetDeal(string sku)
        {
            return Deals.TryGetValue(sku, out var dealProvider) ? dealProvider : new DoNothingDeal();
        }
    }
}