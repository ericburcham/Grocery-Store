namespace GroceryStore.Discounts
{
    public interface IProvideDiscountProviders
    {
        IProvideDiscounts GetDiscount(string sku);
    }
}