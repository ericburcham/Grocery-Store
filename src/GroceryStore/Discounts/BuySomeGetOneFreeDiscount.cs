namespace GroceryStore.Discounts
{
    public class BuySomeGetOneFreeDiscount : IDiscountStrategy
    {
        private readonly uint _quantityToGetOneFree;

        public BuySomeGetOneFreeDiscount(uint quantityToGetOneFree)
        {
            _quantityToGetOneFree = quantityToGetOneFree;
        }

        public decimal GetDiscount(uint quantity, decimal price)
        {
            if (quantity < _quantityToGetOneFree) return 0;

            // ReSharper disable once PossibleLossOfFraction
            return quantity / _quantityToGetOneFree * price;
        }
    }
}