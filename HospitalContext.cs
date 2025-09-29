using Microsoft.EntityFrameworkCore;
using HospitalApp.Models;

namespace HospitalApp
{
    public class HospitalContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Replace with your actual SQL Server connection string
            optionsBuilder.UseSqlServer(@"Server=ISHTIYAG\SQLEXPRESS;Database=HospitalDB;Trusted_Connection=True;TrustServerCertificate=True;");

        }
    }
}
