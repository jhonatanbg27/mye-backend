using System.Collections.Generic;
using Hospital.Entity;
using Hospital.Repositoy.dbcontext;

namespace Hospital.Repositoy.implementation
{
    public class ConsultaRepository : IConsultaRepository
    {
        private ApplicationDbContext context;

        public ConsultaRepository(ApplicationDbContext context)
        {
            this.context = context;
        }



        public Consulta Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Consulta> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public bool Save(Consulta entity)
        {
            throw new System.NotImplementedException();
        }

        public bool Update(Consulta entity)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}