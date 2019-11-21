using System.Collections.Generic;
using MyE.Domain;

namespace MyE.Service.implementation
{
    public class ScheduleService : IScheduleService
    {
        private IScheduleService scheduleRepository;
        public ScheduleService(IScheduleService scheduleRepository)
        {
            this.scheduleRepository = scheduleRepository;
        }
         public bool Delete(int id)
        {
            this.scheduleRepository.Delete(id);
        }

        public Schedule Get(int id)
        {
            this.scheduleRepository.Get(id);
        }

        public IEnumerable<Schedule> GetAll()
        {
           this.scheduleRepository.GetAll();
        }

        public bool Save(Schedule entity)
        {
            this.scheduleRepository.Save(entity);
        }

        public bool Update(Schedule entity)
        {
            this.scheduleRepository.Update(entity);
        }
    }
}