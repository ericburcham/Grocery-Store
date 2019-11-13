namespace GroceryStore.Discounts
{
    public interface IDiscountStrategy
    {
        decimal GetDiscount(uint quantity, decimal price);
    }
}