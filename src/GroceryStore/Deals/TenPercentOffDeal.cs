namespace GroceryStore.Deals
{
    public class TenPercentOffDeal : IDeal
    {
        public decimal GetDiscount(uint quantity, decimal price)
        {
            return 0.1M * (quantity * price);
        }
    }
}