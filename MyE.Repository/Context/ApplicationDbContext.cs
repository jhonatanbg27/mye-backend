using MyE.Domain;
using Microsoft.EntityFrameworkCore;
using MyE.Domain;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using System;

namespace MyE.Repository.Context
{
    public class ApplicationDbContext: DbContext
    {
        //Esto va tener el nombre en mayuscula
       
        public DbSet<FinalReport> FinalReports {get;set;}
        public DbSet<MachineReview> MachineReviews {get;set;}
        public DbSet<MedicalEquipment> MedicalEquipments {get;set;} //corregir en los demas
        public DbSet<Membership> Memberships {get;set;}
        public DbSet<Order> Orders {get;set;}
        public DbSet<Role> Roles {get;set;}
        public DbSet<Schedule> Schedules {get;set;}
         public DbSet<User> Users {get;set;}
         public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}


    }
}