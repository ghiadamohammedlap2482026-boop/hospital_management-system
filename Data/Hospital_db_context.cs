using hospital.Models;
using Microsoft.EntityFrameworkCore;

namespace hospital.Data
{
    public class Hospital_db_context : DbContext
    {
        public DbSet<Department> Department { get; set; }
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<Treatment> Treatment { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=(localdb)\\MSSQLLocalDB;Database=Hospital_db;Trusted_connection=True;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Treatment>()
                .HasKey(t => new { t.Doctor_ID, t.Patient_ID });

            modelBuilder.Entity<Treatment>()
                .HasOne(t => t.Doctor)
                .WithMany()
                .HasForeignKey(t => t.Doctor_ID);

            modelBuilder.Entity<Treatment>()
                .HasOne(t => t.Patient)
                .WithMany()
                .HasForeignKey(t => t.Patient_ID);
        }

    }
}