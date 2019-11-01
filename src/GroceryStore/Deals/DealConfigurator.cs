namespace GroceryStore.Deals
{
    public class DealConfigurator : DealProvider, IConfigureDeals
    {
        public void AddDeal(string sku, IDeal deal)
        {
            Deals.Add(sku, deal);
        }
    }
}