using System.Collections.Generic;
using Hospital.Entity;
using Hospital.Repositoy;

namespace Hospital.Service.implementation
{
    public class MachinereviewService : IMachinereviewService
    {
         private IMachinereviewRepository machinereviewRepository;
        public MachinereviewService(IMachinereviewRepository machinereviewRepository)
        {
            this.machinereviewRepository=machinereviewRepository;
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
            return machinereviewRepository.GetAll();
        }

        public bool Save(Machinereview entity)
        {
            return machinereviewRepository.Save(entity);
        }

        public bool Update(Machinereview entity)
        {
            return machinereviewRepository.Update(entity);
        }
    }
}