using Microsoft.EntityFrameworkCore;
using UniversityAdmisionApplcation.Models;

namespace UniversityAdmisionApplcation.Database
{
    public class ApplicationDbContex:DbContext
    {

        public ApplicationDbContex(DbContextOptions<ApplicationDbContex> options)
           : base(options)
        {
        }

        public DbSet<Registration> Registrations { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<AdmissionOfficer> admissionOfficers { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Registration>().ToTable("Registration");
            modelBuilder.Entity<Faculty>().ToTable("Faculty");
            modelBuilder.Entity<AdmissionOfficer>().ToTable("AdmissionOfficer");
        }

    }
}
