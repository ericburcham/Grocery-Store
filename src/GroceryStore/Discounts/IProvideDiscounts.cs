namespace GroceryStore.Discounts
{
    public interface IProvideDiscounts
    {
        decimal GetDiscount(string sku, uint quantity, decimal price);
    }
}