using System.Collections.Generic;
using MyE.Domain;

namespace MyE.Service.implementation
{
    public class MachineReviewService : IMachineReviewService
    {
        private IMachineReviewService machineReviewRepository;
        public MachineReviewService(IMachineReviewService machineReviewRepository)
        {
            this.machineReviewRepository = machineReviewRepository;
        }
        public bool Delete(int id)
        {
            this.machineReviewRepository.Delete(id);
        }

        public MachineReview Get(int id)
        {
            this.machineReviewRepository.Get(id);
        }

        public IEnumerable<MachineReview> GetAll()
        {
            this.machineReviewRepository.GetAll();
        }

        public bool Save(MachineReview entity)
        {
            this.machineReviewRepository.Save(entity);
        }

        public bool Update(MachineReview entity)
        {
            this.machineReviewRepository.Update(entity);
        }
    }
}