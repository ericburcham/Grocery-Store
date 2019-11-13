using System;

namespace GroceryStore.Discounts
{
    public interface IManageDiscounts
    {
        void AddDiscount(string sku, IProvideDiscounts discount);
    }

    public interface IProvideDiscounts
    {
    }

    public class DollarOffDiscount : IProvideDiscounts
    {
    }

    public class DiscountManager : IManageDiscounts
    {
        public void AddDiscount(string sku, IProvideDiscounts discount)
        {
            throw new NotImplementedException();
        }
    }
}