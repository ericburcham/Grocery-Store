namespace GroceryStore.Discounts
{
    public abstract class FixedDiscount : IDiscountStrategy
    {
        private readonly decimal _discount;

        protected FixedDiscount(decimal discount)
        {
            _discount = discount;
        }

        public decimal GetDiscount(uint quantity, decimal price)
        {
            return quantity * _discount;
        }
    }
}