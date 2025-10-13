using Microsoft.EntityFrameworkCore;

namespace Day1ITIASP.Models
{
    public class AppDBcontext : DbContext
    {
        public AppDBcontext() {}

        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        public DbSet<InstructorCourse> InstructorCourses { get; set; }

        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =LAPTOP-BVUVG18K\\MSSQLSERVER3 ; Database = Day2ITIRazor ;User Id=sa; Password=123; Encrypt=True; TrustServerCertificate=True");
        }
        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentCourse>()
                .HasKey(sc => new { sc.StudentSSN, sc.CourseId });
            modelBuilder.Entity<InstructorCourse>()
                .HasKey(ic => new { ic.InstructorId, ic.CourseId });
        }
    }
}
