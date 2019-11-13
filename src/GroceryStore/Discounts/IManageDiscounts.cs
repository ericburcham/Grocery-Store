namespace GroceryStore.Discounts
{
    public interface IManageDiscounts
    {
        void AddDiscount(string sku, IProvideDiscounts discount);

        IProvideDiscounts GetDiscount(string sku);
    }
}