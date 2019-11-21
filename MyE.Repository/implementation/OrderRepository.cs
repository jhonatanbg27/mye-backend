using System.Collections.Generic;
using MyE.Domain;

namespace MyE.Repository.implementation
{
    public class OrderRepository : IOrderRepository
    {
        public OrderRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public bool Delete(int id)
        {
            try
            {
                var result = new Orders();
                result = context.Orders.Single(x=> x.Id == id ); 
                context.Remove(result);
                context.SaveChanges();
                return true;
            }
            catch(System.Exception)
            {
                throw;
            }
        }

        public Order Get(int id)
        {
            var result =  new Orders();
            try {
                result = context.Orders.Single(x =>x.Id == id);
            }catch(System.Exception)
            {
                throw;
            }
            return result;
        }

        public IEnumerable<Order> GetAll()
        {
            var result = new List<Order>();
            try{
                result = context.Orders.ToList();
            }catch(System.Exception)
            {
                throw;
            }
            return result;
        }

        public bool Save(Order entity)
        {
            try
            {
                context.Add(entity);
                context.SaveChanges();
            }
            catch(System.Exception)
            {
                return false;
            }
            return true;
        }

        public bool Update(Order entity)
        {
             try{
                var newOrder = context.Order.Single(x => x.Id == entity.Id);
                newOrder.OrderId = entity.OrderId;
                newOrder.Priority = entity.Priority;
                newOrder.Date = entity.Date;
                context.Update(newOrder);
                context.SaveChanges();
            }
            catch(System.Exception)
            {
                return false;
            }
            return true;
        }
    }
}

//añadir el fk