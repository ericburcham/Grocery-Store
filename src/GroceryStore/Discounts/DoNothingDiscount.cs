namespace GroceryStore.Discounts
{
    public class DoNothingDiscount : IDiscountStrategy
    {
        public decimal GetDiscount(uint quantity, decimal price)
        {
            return 0M;
        }
    }
}