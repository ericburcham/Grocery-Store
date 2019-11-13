namespace GroceryStore.Discounts
{
    public class DollarOffDiscount : IProvideDiscounts
    {
        public decimal GetDiscount(uint quantity, decimal price)
        {
            return quantity;
        }
    }
}