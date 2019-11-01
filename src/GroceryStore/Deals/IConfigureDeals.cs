namespace GroceryStore.Deals
{
    public interface IConfigureDeals : IProvideDeals
    {
        void AddDeal(string sku, IDeal deal);
    }
}