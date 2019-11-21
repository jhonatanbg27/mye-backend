using System.Collections.Generic;
using MyE.Domain;

namespace MyE.Repository.implementation
{
    public class UserRepository : IUserRepository
    {
        public UserRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public bool Delete(int id)
        {
            try
            {
                var result = new Users();
                result = context.Users.Single(x=> x.Id == id ); 
                context.Remove(result);
                context.SaveChanges();
                return true;
            }
            catch(System.Exception)
            {
                throw;
            }
        }

        public User Get(int id)
        {
            var result =  new Users();
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
                newUser.IdUser = entity.IdUser;
                newUser.IdRole = entity.IdRole;
                newUser.Name = entity.Name;
                newUser.Tipodoc = entity.Tipodoc;
                newUser.Numdoc = entity.Numdoc;
                newUser.Address = entity.Address;
                newUser.Phone = entity.Phone;
                newUser.Email = entity.Email;
                newUser.Condition = entity.Condition;

                context.Update(newUser);
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