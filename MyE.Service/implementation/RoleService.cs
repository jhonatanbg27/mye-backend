using System.Collections.Generic;
using MyE.Domain;

namespace MyE.Service.implementation
{
    public class RoleService : IRoleService
    {
        private IRoleService roleRepository;
        public RoleService(IRoleService roleRepository)
        {
            this.roleRepository = roleRepository;
        }

         public bool Delete(int id)
        {
        this.roleRepository.Delete(id);
        }

        public Role Get(int id)
        {
            this.roleRepository.Get(id);
        }

        public IEnumerable<Role> GetAll()
        {
           this.roleRepository.GetAll();
        }

        public bool Save(Role entity)
        {
            this.roleRepository.Save(entity);
        }

        public bool Update(Role entity)
        {
            this.roleRepository.Update(entity);
        }
    }
}