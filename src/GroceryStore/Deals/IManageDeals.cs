using System;
using System.Collections.Generic;

namespace GroceryStore.Deals
{
    public interface IManageDeals
    {
        void AddDeal(string sku, IDeal deal);

        IDeal GetDeal(string sku);
    }

    public interface IDeal
    {
        decimal GetDiscount(uint quantity, decimal price);
    }

    public class DoNothingDeal : IDeal
    {
        public decimal GetDiscount(uint quantity, decimal price)
        {
            return 0;
        }
    }

    public class DollarOffDeal : IDeal
    {
        public decimal GetDiscount(uint quantity, decimal price)
        {
            return quantity;
        }
    }

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