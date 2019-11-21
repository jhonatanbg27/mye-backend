using System.Collections.Generic;
using MyE.Domain;

namespace MyE.Repository.implementation
{
    public class MedicalEquipamentRepository : IMedicalEquipamentRepository
    {
        public MedicalEquipamentRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public bool Delete(int id)
        {
            try
            {
                var result = new MedicalEquipaments();
                result = context.MedicalEquipaments.Single(x=> x.Id == id ); 
                context.Remove(result);
                context.SaveChanges();
                return true;
            }
            catch(System.Exception)
            {
                throw;
            }
        }
        public MedicalEquipament Get(int id)
        {
            var result =  new MedicalEquipaments();
            try {
                result = context.MedicalEquipaments.Single(x =>x.Id == id);
            }catch(System.Exception)
            {
                throw;
            }
            return result;
        }

        public IEnumerable<MedicalEquipament> GetAll()
        {
             var result = new List<MedicalEquipament>();
            try{
                result = context.MedicalEquipaments.ToList();
            }catch(System.Exception)
            {
                throw;
            }
            return result;
        }

        public bool Save(MedicalEquipament entity)
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

        public bool Update(MedicalEquipament entity)
        {
            try{
                var newMedicalEquipament = context.MedicalEquipaments.Single(x => x.Id == entity.Id);
                newMedicalEquipament.Id = entity.Id;  
                newMedicalEquipament.StateDescription = entity.StateDescription;  
                newMedicalEquipament.Brand = entity.Brand;
                newMedicalEquipament.Name = entity.Name; 
                context.Update(newMedicalEquipament);
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