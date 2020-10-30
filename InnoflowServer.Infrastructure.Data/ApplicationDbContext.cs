using InnoflowServer.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Globalization;

namespace InnoflowServer.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserJobCategorie> UserJobCategories { get; set; }
        public DbSet<JobCategorie> JobCategories { get; set; }
        public DbSet<Role> Role { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    FirstName = "Anton",
                    LastName = "Zdit",
                    Email = "zdit@mail.ru",
                    Password = "1234",
                    RoleId = 1
                });
            modelBuilder.Entity<JobCategorie>().HasData(
                new JobCategorie
                {
                    Id = 1,
                    Name = "Andersen",
                });
            modelBuilder.Entity<UserJobCategorie>().HasData(
                new UserJobCategorie
                {
                    Id = 1,
                    UserId = 1,
                    JobCaregorieId = 1
                });
            modelBuilder.Entity<Role>().HasData(
                new Role
                {
                    Id = 1,
                    Name = "Admin"
                });
            modelBuilder.Entity<UserJobCategorie>()
                .HasKey(t => new { t.UserId, t.JobCaregorieId });
            modelBuilder.Entity<UserJobCategorie>()
                .HasOne(ju => ju.User)
                .WithMany(j => j.UserJobCategories)
                .HasForeignKey(ju => ju.UserId);
            modelBuilder.Entity<UserJobCategorie>()
                .HasOne(ju => ju.JobCategorie)
                .WithMany(j => j.UserJobCategories)
                .HasForeignKey(ju => ju.JobCaregorieId);
            modelBuilder.Entity<Role>()
                .HasMany(ju => ju.Users)
                .WithOne(j => j.Role)
                .HasForeignKey(ju => ju.RoleId);
            base.OnModelCreating(modelBuilder);
        }
    }
}
