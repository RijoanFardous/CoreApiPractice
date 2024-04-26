using CoreApiPractice.EF.Entities;
using Microsoft.EntityFrameworkCore;

namespace CoreApiPractice.EF
{
    public class UniversityMSContext : DbContext
    {
        public UniversityMSContext(DbContextOptions options) : base(options) { }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Course> Courses { get; set; }
    }
}
