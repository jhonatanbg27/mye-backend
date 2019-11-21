using System.Collections.Generic;
using MyE.Domain;

namespace MyE.Service.implementation
{
    public class MembershipService : IMembershipService
    {
        private IMembershipService membershipRepository;
        public MembershipService(IMembershipService membershipRepository)
        {
            this.membershipRepository = membershipRepository;
        }
         public bool Delete(int id)
        {
           this.membershipRepository.Delete(id);
        }

        public Membership Get(int id)
        {
            this.membershipRepository.Get(id);
        }

        public IEnumerable<Membership> GetAll()
        {
            this.membershipRepository.GetAll();
        }

        public bool Save(Membership entity)
        {
           this.membershipRepository.Save(entity);
        }

        public bool Update(Membership entity)
        {
           this.membershipRepository.Update(entity);
        }
    }
}