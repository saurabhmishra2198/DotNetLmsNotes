using Microsoft.EntityFrameworkCore;

namespace OneToManyCodeFirst.Models
{
    public class StudentProjectContext : DbContext
    {
        public StudentProjectContext(DbContextOptions<StudentProjectContext> options) : base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Project> Projects { get; set; }
    }
}
