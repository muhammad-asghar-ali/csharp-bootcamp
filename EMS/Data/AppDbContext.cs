using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using EMS.Models;

namespace EMS.Data
{
    class AppDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public DbSet<Manager> Managers { get; set; }

        public DbSet<EmployeeDetails> EmployeeDetails { get; set; }

        public DbSet<Project> Projects { get; set; }

        public DbSet<EmployeeProject> EmployeeProjects { get; set; }


        public string ConnectionString { get; }

        public AppDbContext()
        {
            ConnectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (string.IsNullOrEmpty(ConnectionString))
            {
                throw new InvalidOperationException("Connection string is not set in environment variables.");
            }

            options.UseSqlServer(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeProject>()
                .HasKey(ep => new { ep.EmployeeId, ep.ProjectId });

            modelBuilder.Entity<EmployeeProject>()
                .HasOne(ep => ep.Employee)
                .WithMany(s => s.EmployeeProjects)
                .HasForeignKey(ep => ep.EmployeeId);

            modelBuilder.Entity<EmployeeProject>()
                .HasOne(ep => ep.Project)
                .WithMany(p => p.EmployeeProjects)
                .HasForeignKey(ep => ep.ProjectId);
        }
    }
}