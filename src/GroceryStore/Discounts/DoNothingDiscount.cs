namespace GroceryStore.Discounts
{
    public class DoNothingDiscount : IProvideDiscounts
    {
        public decimal GetDiscount(uint quantity, decimal price)
        {
            throw new System.NotImplementedException();
        }
    }
}