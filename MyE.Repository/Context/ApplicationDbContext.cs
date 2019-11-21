using MyE.Domain;
using Microsoft.EntityFramewrokCore;
using MyE.Domain.Domain;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using System;

namespace MyE.Repository.Context
{
    public class ApplicationDbContext: DbContext
    {
        //Esto va tener el nombre en mayuscula
        public DbSet<User> User {get;set;}
        public DbSet<Role> Role {get;set;}
    }
}