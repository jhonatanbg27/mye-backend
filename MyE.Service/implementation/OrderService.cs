using System.Collections.Generic;
using MyE.Domain;

namespace MyE.Service.implementation
{
    public class OrderService : IOrderService
    {
        private IOrderService orderRepository;
        public OrderService(IOrderService orderRepository)
        {
            this.orderRepository = orderRepository;
        }
         public bool Delete(int id)
        {
            this.orderRepository.Delete(id);
        }

        public Order Get(int id)
        {
            this.orderRepository.Get(id);
        }

        public IEnumerable<Order> GetAll()
        {
            this.orderRepository.GetAll();
        }

        public bool Save(Order entity)
        {
            this.orderRepository.Save(entity);
        }

        public bool Update(Order entity)
        {
            this.orderRepository.Update(entity);
        }
    }
}