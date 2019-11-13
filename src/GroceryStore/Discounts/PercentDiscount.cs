﻿namespace GroceryStore.Discounts
{
    public abstract class PercentDiscount : IProvideDiscounts
    {
        private readonly decimal _discountMultiplier;

        protected PercentDiscount(decimal discountMultiplier)
        {
            _discountMultiplier = discountMultiplier;
        }

        public decimal GetDiscount(uint quantity, decimal price)
        {
            return quantity * price * _discountMultiplier;
        }
    }
}