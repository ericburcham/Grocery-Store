namespace GroceryStore.Deals
{
    public interface IManageDeals
    {
        void AddDeal(string sku, IDeal deal);

        IDeal GetDeal(string sku);
    }
}