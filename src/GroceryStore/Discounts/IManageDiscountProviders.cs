namespace GroceryStore.Discounts
{
    public interface IManageDiscountProviders : IProvideDiscountProviders
    {
        void AddDiscount(string sku, IProvideDiscounts discount);
    }
}