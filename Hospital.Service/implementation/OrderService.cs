using System.Collections.Generic;
using Hospital.Entity;
using Hospital.Repositoy;

namespace Hospital.Service.implementation
{
    public class OrderService : IOrderService
    {

        private IOrderRepository orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            this.orderRepository=orderRepository;
        }
        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Order Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Order> GetAll()
        {
            return orderRepository.GetAll();
        }

        public bool Save(Order entity)
        {
           return orderRepository.Save(entity);
        }

        public bool Update(Order entity)
        {
           return orderRepository.Update(entity);
        }
    }
}