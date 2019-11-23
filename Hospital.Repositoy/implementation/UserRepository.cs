using System.Collections.Generic;
using System.Linq;
using Hospital.Entity;

using Hospital.Repositoy.dbcontext;

namespace Hospital.Repositoy.implementation
{
    public class UserRepository : IUserRepository
    {
         private ApplicationDbContext context;
        public UserRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
         public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public User Get(int id)
        {
             var result = new User();
            try {
                result = context.Users.Single(x =>x.Id == id);
            }catch(System.Exception)
            {
                throw;
            }
            return result;
        }

        public IEnumerable<User> GetAll()
        {
           var result = new List<User>();
            try{
                result = context.Users.ToList();
            }catch(System.Exception)
            {
                throw;
            }
            return result;
        }

        public bool Save(User entity)
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

        public bool Update(User entity)
        {
            try{
                var newUser = context.Users.Single(x => x.Id == entity.Id);
                newUser.Id = entity.Id;
                newUser.Idrol= entity.Idrol;
                newUser.Tipodoc = entity.Tipodoc;
                newUser.Numdoc = entity.Numdoc;
                newUser.Name = entity.Name;
                newUser.Email=entity.Email;
                newUser.Address=entity.Address;
                newUser.Phone = entity.Phone;

                context.Update(newUser);
                 context.SaveChanges();
            }
            catch(System.Exception)
            {
                return true;
            }
            return false;
        }
    }
}