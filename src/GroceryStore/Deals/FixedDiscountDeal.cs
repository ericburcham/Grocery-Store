namespace GroceryStore.Deals
{
    public abstract class FixedDiscountDeal: IDeal
    {
        private readonly decimal _discount;

        public FixedDiscountDeal(decimal discount)
        {
            _discount = discount;
        }
        public decimal GetDiscount(uint quantity, decimal price)
        {
            return quantity * _discount;
        }
    }
}