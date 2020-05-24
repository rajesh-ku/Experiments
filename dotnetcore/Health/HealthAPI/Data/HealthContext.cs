using HealthAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace HealthAPI.Data
{
    public class HealthContext : DbContext
    {
        public HealthContext(DbContextOptions options) : base(options) {  }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ailment>().Property(p => p.Name).HasMaxLength(255);
            modelBuilder.Entity<Patient>().Property(p => p.Name).HasMaxLength(255);
            modelBuilder.Entity<Medication>().Property(p => p.Name).HasMaxLength(255);
        }    

        public DbSet<Patient> Patients { get; set; }

        public DbSet<Ailment> Ailments { get; set; }

        public DbSet<Medication> Medications { get; set; }
    }
}