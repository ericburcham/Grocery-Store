namespace GroceryStore.Discounts
{
    public class DiscountProviderManager : DiscountProviderProvider, IManageDiscountProviders
    {
        public void AddDiscount(string sku, IProvideDiscounts discount)
        {
            DiscountProviders.Add(sku, discount);
        }
    }
}
