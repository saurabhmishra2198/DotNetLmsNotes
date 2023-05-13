using Microsoft.EntityFrameworkCore;

namespace OneToOneCodeFirstDemo.Models
{
    public class SchoolDBContext : DbContext
    {
        public SchoolDBContext(DbContextOptions<SchoolDBContext> options) : base(options)
        {

        }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Student>()
        //        .HasOne(s => s.Address)
        //        .WithOne(a => a.Student)
        //        .HasForeignKey<StudentAddress>(a => a.StudentId);
        //}
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentAddress> StudentAddresses { get; set; }
    }
}
