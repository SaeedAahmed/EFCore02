using EFCore02.Entites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EFCore02.Contexts
{
    internal class ITI02Dbcontext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server = . ; Database = EF02 ; Trusted_Connection= true ; Encrypt=False");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Stud_Course> Stud_Course { get; set; }
        public DbSet<Instructor> Instructor { get; set; }
        public DbSet<Course_ins> Course_ins { get; set; }
        public DbSet<Topic> Topic { get; set; }
    }
}
