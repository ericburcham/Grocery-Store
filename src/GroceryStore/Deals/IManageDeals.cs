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

    public class DollarOffDeal : IDeal
    {
        public decimal GetDiscount(uint quantity, decimal price)
        {
            throw new System.NotImplementedException();
        }
    }

    public class DealManager : IManageDeals
    {
        public void AddDeal(string sku, IDeal deal)
        {
            throw new System.NotImplementedException();
        }

        public IDeal GetDeal(string sku)
        {
            throw new System.NotImplementedException();
        }
    }
}