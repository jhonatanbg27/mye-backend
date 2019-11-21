using System.Collections.Generic;
using MyE.Domain;

namespace MyE.Service.implementation
{
    public class FinalReportService : IFinalReportService
    {
        private IFinalReportService finalReportRepository;
        public FinalReportService(IFinalReportService finalReportRepository)
        {
            this.finalReportRepository = finalReportRepository;
        }
       public bool Delete(int id)
        {
            this.finalReportRepository.Delete(id);
        }

        public FinalReport Get(int id)
        {
            this.finalReportRepository.Get(id);
        }

        public IEnumerable<FinalReport> GetAll()
        {
            this.finalReportRepository.GetAll();
        }

        public bool Save(FinalReport entity)
        {
            this.finalReportRepository.Save(entity);
        }

        public bool Update(FinalReport entity)
        {
            this.finalReportRepository.Update(entity);
        }
    }
}