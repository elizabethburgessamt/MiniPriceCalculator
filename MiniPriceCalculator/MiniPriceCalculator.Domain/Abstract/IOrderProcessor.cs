using MiniPriceCalculator.Domain.Entities;

namespace MiniPriceCalculator.Domain.Abstract
{
    public interface IOrderProcessor
    {
        void ProcessOrder(Cart cart, ShippingDetails shippingDetails);
    }
}
