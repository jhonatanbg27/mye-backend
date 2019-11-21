using System.Collections.Generic;
using MyE.Domain;
using MyE.Repository;
namespace MyE.Service.implementation
{
    public class UserService : IUserService
    {
        private IUserRepository userRepository;
        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
         public bool Delete(int id)
        {
            this.userRepository.Delete(id);
        }

        public User Get(int id)
        {
            this.userRepository.Get(id);
        }

        public IEnumerable<User> GetAll()
        {
           this.userRepository.GetAll();
        }

        public bool Save(User entity)
        {
           this.userRepository.Save(entity);
        }

        public bool Update(User entity)
        {
            this.userRepository.Update(entity);
        }
    }
}