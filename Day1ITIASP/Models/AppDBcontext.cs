using Microsoft.EntityFrameworkCore;

namespace Day1ITIASP.Models
{
    public class AppDBcontext : DbContext
    {
        public AppDBcontext() {}

        public DbSet<Student> Students { get; set; }

        override protected void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server =LAPTOP-BVUVG18K\\MSSQLSERVER3 ; Database = Day1ITIRazor ;User Id=sa; Password=123; Encrypt=True; TrustServerCertificate=True");
        }
    }
}
