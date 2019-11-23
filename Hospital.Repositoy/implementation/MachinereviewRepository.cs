using System.Collections.Generic;
using System.Linq;
using Hospital.Entity;
using Hospital.Repositoy.dbcontext;

namespace Hospital.Repositoy.implementation
{
    public class MachinereviewRepository : IMachinereviewRepository
    {

         private ApplicationDbContext context;

        public  MachinereviewRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Machinereview Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Machinereview> GetAll()
        {
           var result = new List<Machinereview>();
            try
            {
                result = context.Machinereviews.ToList();
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public bool Save(Machinereview entity)
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

        public bool Update(Machinereview entity)
        {
             try
            {
                 var machinereviewOrigina = context.Machinereviews.Single(
                     x => x.Id == entity.Id
                 );

                machinereviewOrigina.Id=entity.Id;
                 machinereviewOrigina.Reviewdate = entity.Reviewdate;
                 machinereviewOrigina.Idschedule = entity.Idschedule;

                 context.Update(machinereviewOrigina);
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