namespace GroceryStore.Discounts
{
    public class DiscountManager : DiscountProvider, IManageDiscounts
    {
        public void AddDiscount(string sku, IDiscountStrategy discountStrategy)
        {
            ConfiguredDiscounts.Add(sku, discountStrategy);
        }
    }
}