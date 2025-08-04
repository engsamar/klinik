using Klinik.Models;
using Microsoft.EntityFrameworkCore;

namespace Klinik.DataAccess
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            // optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=ECommerce517;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;");
            optionsBuilder.UseMySql("server=localhost;database=klinik;user=root;password=;", new MySqlServerVersion(new Version(8, 0, 21)));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}