namespace GroceryStore.Discounts
{
    public class DoNothingDiscount : IProvideDiscounts
    {
        public decimal GetDiscount(uint quantity, decimal price)
        {
            return 0M;
        }
    }
}