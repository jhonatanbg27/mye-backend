using System.Collections.Generic;
using System.Linq;
using Hospital.Entity;
using Hospital.Repositoy.dbcontext;

namespace Hospital.Repositoy.implementation
{
    public class FinalreportRepository : IFinalreportRepository
    {
           private ApplicationDbContext context;

        public FinalreportRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Finalreport Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Finalreport> GetAll()
        {
           var result = new List<Finalreport>();
            try
            {
                result = context.Finalreports.ToList();
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public bool Save(Finalreport entity)
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

        public bool Update(Finalreport entity)
        {
            try
            {
                 var finalreportOrigina = context.Finalreports.Single(
                     x => x.Id == entity.Id
                 );

                 finalreportOrigina.Id=entity.Id;
                 finalreportOrigina.Description=entity.Description;
                 finalreportOrigina.Reportdate =entity.Reportdate;
                 finalreportOrigina.Idmachinereview=entity.Idmachinereview;
                

                 context.Update(finalreportOrigina);
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