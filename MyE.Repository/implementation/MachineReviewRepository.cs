using System.Collections.Generic;
using MyE.Domain;
using MyE.Repository.Context;
using System.Linq;



namespace MyE.Repository.Implementation
{
    public class MachineReviewRepository : IMachineReviewRepository
    {
        private ApplicationDbContext context;
        public MachineReviewRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public bool Delete(int id)
        {
            try
            {
                var result = new MachineReview();
                result = context.MachineReviews.Single(x=> x.Id == id ); 
                context.Remove(result);
                context.SaveChanges();
                return true;
            }
            catch(System.Exception)
            {
                throw;
            }
        }

        public MachineReview Get(int id)
        {
            var result = new MachineReview();
            try {
                result = context.MachineReviews.Single(x =>x.Id == id);
            }catch(System.Exception)
            {
                throw;
            }
            return result;
        }

        public IEnumerable<MachineReview> GetAll()
        {
            var result = new List<MachineReview>();
            try{
                result = context.MachineReviews.ToList();
            }catch(System.Exception)
            {
                throw;
            }
            return result;
        }

        public bool Save(MachineReview entity)
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

        public bool Update(MachineReview entity)
        {
            try{
                var newFinalReport = context.MachineReviews.Single(x => x.Id == entity.Id);
                newFinalReport.Id = entity.Id;
                context.Update(newFinalReport);
                context.SaveChanges();
            }
            catch(System.Exception)
            {
                return true;
            }
            return false;
        }
        public IEnumerable<MachineReview> GetMachineReviewByOrder(int orderId)
        {
            try
            {
                var MachineReviews = context.MachineReviews.Where(x => x.OrderId == orderId);
                return MachineReviews;
            }
            catch (System.Exception)
            {
                return null;
            }
        }
       /* public IEnumerable<MachineReview> GetFinalReportsByUser(int userId)
        {
            try
            {
                var MachineReviews = context.MachineReviews.Where(x => x.UserId == userId);
                return MachineReviews;
            }
            catch (System.Exception)
            {
                return null;
            }
        }*/
    }
}