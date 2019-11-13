namespace GroceryStore.Discounts
{
    public interface IProvideDiscounts
    {
        decimal GetDiscount(uint quantity, decimal price);
    }
}