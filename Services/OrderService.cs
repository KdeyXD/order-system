using DecoratorDrink.Logic.Composite;
using MiniPOS.Data;

namespace MiniPOS.Service
{
    public class OrderService
    {
        private readonly OrderRepository _orderRepository;

        public OrderService()
        {
            _orderRepository = new OrderRepository();
        }

        public int SaveOrder(Order order)
        {
            if (order == null || !order.Items.Any())
                throw new InvalidOperationException("Order is empty.");

            return _orderRepository.InsertOrder(order);
        }
    }
}
