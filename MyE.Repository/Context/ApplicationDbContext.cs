using MyE.Domain;
using Microsoft.EntityFramewrokCore;

namespace MyE.Repository.Context
{
    public class ApplicationDbContext: DbContext
    {
        //Esto va tener el nombre en mayuscula
        public DbSet<User> User {get;set;}
        public DbSet<Role> Role {get;set;
        }

        public ApplicationDbContext(DbContextOptions options):base(options)
        {

        }
          public override int SaveChanges()
        {
            AddTimestamps();
            return base.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

    }
}