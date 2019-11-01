using System;

namespace GroceryStore.Deals
{
    public abstract class FixedDiscountDeal : IDeal
    {
        private readonly decimal _discount;

        protected FixedDiscountDeal(decimal discount)
        {
            _discount = discount;
        }

        public decimal GetDiscount(uint quantity, decimal price)
        {
            if (price < _discount)
            {
                throw new InvalidOperationException("We're not in the business of giving away merchandise.");
            }

            return quantity * _discount;
        }
    }
}