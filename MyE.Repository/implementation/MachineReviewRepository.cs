using System.Collections.Generic;
using MyE.Domain;

namespace MyE.Repository.implementation
{

    
    public class MachineReviewRepository : IMachineReviewRepository
    {
        public MachineReviewRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public bool Delete(int id)
        {
            try
            {
                var result = new MachineReviews();
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
            var result =  new MachineReviews();
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
                var newMachineReview = context.MachineReviews.Single(x => x.Id == entity.Id);
                newMachineReview.Id = entity.Id;  
                newMachineReview.EngineerId = entity.EngineerId;          
                newMachineReview.ReviewDate = entity.ReviewDate;
                newMachineReview.ReturnDate = entity.ReturnDate;
                newMachineReview.OrderId = entity.OrderId; 
                context.Update(newMachineReview);
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