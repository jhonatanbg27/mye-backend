using System.Collections.Generic;
using MyE.Domain;

namespace MyE.Repository.implementation
{
    public class FinalReportRepository : IFinalReportRepository
    {
        public FinalRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public bool Delete(int id)
        {
            try
            {
                var result = new FinalReports();
                result = context.FinalReports.Single(x=> x.Id == id ); 
                context.Remove(result);
                context.SaveChanges();
                return true;
            }
            catch(System.Exception)
            {
                throw;
            }
        }

        public FinalReport Get(int id)
        {
            var result =  new FinalReports();
            try {
                result = context.FinalReports.Single(x =>x.Id == id);
            }catch(System.Exception)
            {
                throw;
            }
            return result;
        }

        public IEnumerable<FinalReport> GetAll()
        {
            var result = new List<FinalReport>();
            try{
                result = context.FinalReports.ToList();
            }catch(System.Exception)
            {
                throw;
            }
            return result;
        }

        public bool Save(FinalReport entity)
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

        public bool Update(FinalReport entity)
        {
           try{
                var newFinalReport = context.FinalReports.Single(x => x.Id == entity.Id);
                newFinalReport.Id = entity.Id;
                newFinalReport.Description = entity.Description;
                newFinalReport.ReportDate = entity.ReportDate;
                context.Update(newFinalReport);
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