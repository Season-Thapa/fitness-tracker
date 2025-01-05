using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Pri.Ee.Core.Entities;
using Pri.Ee.Core.Seeding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pri.Ee.Core.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
          : base(options)
        {

        }
        public DbSet<Goal> Goals { get; set; }
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<Milestone> Milestones { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            DataSeeder.Seed(modelBuilder);
            modelBuilder.Entity<Milestone>()
            .HasOne(m => m.Goal)
            .WithMany(g => g.Milestones)
            .HasForeignKey(m => m.GoalId)
            .OnDelete(DeleteBehavior.Cascade); 

        }
    }
}
