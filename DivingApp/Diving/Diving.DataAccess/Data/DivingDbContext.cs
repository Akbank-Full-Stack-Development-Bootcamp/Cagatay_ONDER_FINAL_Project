using Diving.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diving.DataAccess.Data
{
    public class DivingDbContext : DbContext
    {
        public DivingDbContext()
        {

        }
        public DivingDbContext(DbContextOptions<DivingDbContext> options):base(options)
        {

        }
        public DbSet<DivingSchools> DivingSchools { get; set; }
        public DbSet<HeadInstructor> HeadInstructors { get; set; }
        public DbSet<DivingBoats> DivingBoats { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
