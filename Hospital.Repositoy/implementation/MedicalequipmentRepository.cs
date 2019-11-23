using System.Collections.Generic;
using System.Linq;
using Hospital.Entity;
using Hospital.Repositoy.dbcontext;

namespace Hospital.Repositoy.implementation
{
    public class MedicalequipmentRepository : IMedicalequipmentRepository
    {

         private ApplicationDbContext context;

        public MedicalequipmentRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Medicalequipment Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Medicalequipment> GetAll()
        {
        var result = new List<Medicalequipment>();
            try
            {
                result = context.Medicalequipments.ToList();
            }

            catch (System.Exception)
            {

                throw;
            }
            return result;
         
        }

        public bool Save(Medicalequipment entity)
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

        public bool Update(Medicalequipment entity)
        {
            try
            {
                 var medicalequipmentOrigina = context.Medicalequipments.Single(
                     x => x.Id == entity.Id
                 );

                 medicalequipmentOrigina.Id=entity.Id;
               medicalequipmentOrigina.Statedescription = entity.Statedescription;
                medicalequipmentOrigina.Brand = entity.Brand;
                medicalequipmentOrigina.Name = entity.Name;
                 context.Update(medicalequipmentOrigina);
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