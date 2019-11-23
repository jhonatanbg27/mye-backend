using System.Collections.Generic;
using System.Linq;
using Hospital.Entity;
using Hospital.Repositoy.dbcontext;

namespace Hospital.Repositoy.implementation
{
    public class OrderRepository : IOrderRepository
    {

         private ApplicationDbContext context;

        public OrderRepository(ApplicationDbContext context)
        {
            this.context = context;
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
             var result = new List<Order>();
            try
            {
                result = context.Orders.ToList();
            }

            catch (System.Exception)
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
            catch (System.Exception)
            {

                return false;
            }
            return true;
        }

        public bool Update(Order entity)
        {
           try
            {
                 var orderOrigina = context.Orders.Single(
                     x => x.Id == entity.Id
                 );

                 orderOrigina.Id=entity.Id;
                 orderOrigina.Priority = entity.Priority;
                 orderOrigina.Date=entity.Date;
                 orderOrigina.Idmedicalequipment =entity.Idmedicalequipment;
                 orderOrigina.Descripcion=entity.Descripcion;

                 context.Update(orderOrigina);
                 context.SaveChanges();
            }
            catch (System.Exception)
            {
                
                return false;
            }
            return true;
        }
    }
}