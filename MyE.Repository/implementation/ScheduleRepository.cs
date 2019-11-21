using System.Collections.Generic;
using MyE.Domain;

namespace MyE.Repository.implementation
{
    public class ScheduleRepository : IScheduleRepository
    {
        public ScheduleRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public bool Delete(int id)
        {
            try
            {
                var result = new Schedules();
                result = context.Schedules.Single(x=> x.Id == id ); 
                context.Remove(result);
                context.SaveChanges();
                return true;
            }
            catch(System.Exception)
            {
                throw;
            }
        }

        public Schedule Get(int id)
        {
            var result =  new Schedules();
            try {
                result = context.Schedules.Single(x =>x.Id == id);
            }catch(System.Exception)
            {
                throw;
            }
            return result;
        }

        public IEnumerable<Schedule> GetAll()
        {
           var result = new List<Schedule>();
            try{
                result = context.Schedules.ToList();
            }catch(System.Exception)
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
            catch(System.Exception)
            {
                return false;
            }
            return true;
        }

        public bool Update(Schedule entity)
        {
            try{
                var newSchedule = context.Schedule.Single(x => x.Id == entity.Id);
                newSchedule.Id = entity.Id;
                newSchedule.AgreedDate = entity.AgreedDate;
                newSchedule.ArrivalDate = entity.ArrivalDate;
                newSchedule.EngineerId = entity.EngineerId;
                newSchedule.AdministratorId = entity.AdministratorId;
                context.Update(newSchedule);
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