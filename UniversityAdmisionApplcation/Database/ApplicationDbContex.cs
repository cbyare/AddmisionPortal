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


    }
}
