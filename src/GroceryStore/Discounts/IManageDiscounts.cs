namespace GroceryStore.Discounts
{
    public interface IManageDiscounts : IProvideDiscounts
    {
        void AddDiscount(string sku, IDiscountStrategy discountStrategy);
    }
}