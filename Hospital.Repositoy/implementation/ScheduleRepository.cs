using System.Collections.Generic;
using System.Linq;
using Hospital.Entity;
using Hospital.Repositoy.dbcontext;

namespace Hospital.Repositoy.implementation
{
    
    public class ScheduleRepository : IScheduleRepository
    {

        private ApplicationDbContext context;

        public ScheduleRepository(ApplicationDbContext context)
        {
            this.context = context;
        }        
        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Schedule Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Schedule> GetAll()
        {
            var result = new List<Schedule>();
            try
            {
                result = context.Schedules.ToList();
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
        }

        public bool Save(Schedule entity)
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

        public bool Update(Schedule entity)
        {
            try
            {
                 var scheduleOrigina = context.Schedules.Single(
                     x => x.Id == entity.Id
                 );

                 scheduleOrigina.Id=entity.Id;
                scheduleOrigina.Agreeddate= entity.Agreeddate;
                scheduleOrigina.arrivaldate = entity.arrivaldate;
                scheduleOrigina.Idorder = entity.Idorder;
                scheduleOrigina.Iduser = entity.Iduser;

                 context.Update(scheduleOrigina);
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