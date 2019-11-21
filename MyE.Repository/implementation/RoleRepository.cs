using System.Collections.Generic;
using MyE.Domain;

namespace MyE.Repository.implementation
{
    public class RoleRepository : IRoleRepository

    {
        public RoleRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public bool Delete(int id)
        {
            try
            {
                var result = new Roles();
                result = context.Roles.Single(x=> x.Id == id ); 
                context.Remove(result);
                context.SaveChanges();
                return true;
            }
            catch(System.Exception)
            {
                throw;
            }
        }

        public Role Get(int id)
        {
            var result =  new Roles();
            try {
                result = context.Roles.Single(x =>x.Id == id);
            }catch(System.Exception)
            {
                throw;
            }
            return result;
        }

        public IEnumerable<Role> GetAll()
        {
            var result = new List<Role>();
            try{
                result = context.Roles.ToList();
            }catch(System.Exception)
            {
                throw;
            }
            return result;
        }

        public bool Save(Role entity)
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

        public bool Update(Role entity)
        {
            try{
                var newRole = context.Roles.Single(x => x.Id == entity.Id);
                newRole.IdRole = entity.IdRole;
                newRole.NameRole = entity.NameRole;
                newRole.Description = entity.Description;
                context.Update(newMembership);
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