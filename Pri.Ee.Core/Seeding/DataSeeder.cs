using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Pri.Ee.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pri.Ee.Core.Seeding
{
    public class DataSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var passwordHasher = new PasswordHasher<ApplicationUser>();

            var adminUser = new ApplicationUser
            {
                Name = "admin",
                Email = "admin@pri.be",
                Id = "00000000-0000-0000-0000-000000000001",
                UserName = "admin@pri.be",
                NormalizedEmail = "ADMIN@PRI.BE",
                NormalizedUserName = "admin@pri.be".ToUpper(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
            };
            adminUser.PasswordHash = passwordHasher.HashPassword(adminUser, "Test123?");
            var adminRole = new IdentityRole { Id = "00000000-0000-0000-0000-000000000001", Name = "Admin", NormalizedName = "ADMIN", ConcurrencyStamp = Guid.NewGuid().ToString() };
            var customerUser = new ApplicationUser
            {
                Name = "Customer",
                Email = "customer@pri.be",
                Id = "00000000-0000-0000-0000-000000000002",
                UserName = "customer@pri.be",
                NormalizedEmail = "Customer@PRI.BE",
                NormalizedUserName = "customer@pri.be".ToUpper(),
                ConcurrencyStamp = Guid.NewGuid().ToString(),
            };
            customerUser.PasswordHash = passwordHasher.HashPassword(customerUser, "Test123?");

            var customerRole = new IdentityRole
            {
                Id = "00000000-0000-0000-0000-000000000002",
                Name = "Customer",
                NormalizedName = "CUSTOMER",
                ConcurrencyStamp = Guid.NewGuid().ToString()
            };
            var adminUserRole = new IdentityUserRole<string>
            {
                UserId = adminUser.Id,
                RoleId = adminRole.Id
            };

            var customerUserRole = new IdentityUserRole<string>
            {
                UserId = customerUser.Id,
                RoleId = customerRole.Id
            };

            modelBuilder.Entity<ApplicationUser>().HasData(adminUser, customerUser);
            modelBuilder.Entity<IdentityRole>().HasData(adminRole, customerRole);
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(adminUserRole, customerUserRole);
            var workouts = new List<Workout>
            {
                new Workout { Id = Guid.NewGuid(), UserId = customerUser.Id, Type = "Running", Duration = 30, CaloriesBurned = 300, Date = DateTime.Now.AddDays(-10) },
                new Workout { Id = Guid.NewGuid(), UserId = customerUser.Id, Type = "Cycling", Duration = 60, CaloriesBurned = 500, Date = DateTime.Now.AddDays(-9) },
                new Workout { Id = Guid.NewGuid(), UserId = customerUser.Id, Type = "Swimming", Duration = 45, CaloriesBurned = 400, Date = DateTime.Now.AddDays(-8) },
                new Workout { Id = Guid.NewGuid(), UserId = customerUser.Id, Type = "Yoga", Duration = 30, CaloriesBurned = 100, Date = DateTime.Now.AddDays(-7) },
                new Workout { Id = Guid.NewGuid(), UserId = customerUser.Id, Type = "Weightlifting", Duration = 50, CaloriesBurned = 350, Date = DateTime.Now.AddDays(-6) },
                new Workout { Id = Guid.NewGuid(), UserId = customerUser.Id, Type = "Running", Duration = 25, CaloriesBurned = 270, Date = DateTime.Now.AddDays(-5) },
                new Workout { Id = Guid.NewGuid(), UserId = customerUser.Id, Type = "Cycling", Duration = 40, CaloriesBurned = 400, Date = DateTime.Now.AddDays(-4) },
                new Workout { Id = Guid.NewGuid(), UserId = customerUser.Id, Type = "Swimming", Duration = 50, CaloriesBurned = 450, Date = DateTime.Now.AddDays(-3) },
                new Workout { Id = Guid.NewGuid(), UserId = customerUser.Id, Type = "Yoga", Duration = 35, CaloriesBurned = 120, Date = DateTime.Now.AddDays(-2) },
                new Workout { Id = Guid.NewGuid(), UserId = customerUser.Id, Type = "Hiking", Duration = 90, CaloriesBurned = 600, Date = DateTime.Now.AddDays(-1) },
            };

            var goals = new List<Goal>
            {
                new Goal { Id = Guid.NewGuid(), UserId = customerUser.Id, Description = "Burn 1000 calories this week", Target = 1000, Progress = 750 },
                new Goal { Id = Guid.NewGuid(), UserId = customerUser.Id, Description = "Run 10 km this month", Target = 10, Progress = 6 },
                new Goal { Id = Guid.NewGuid(), UserId = customerUser.Id, Description = "Complete 5 yoga sessions", Target = 5, Progress = 2 },
                new Goal { Id = Guid.NewGuid(), UserId = customerUser.Id, Description = "Swim 3 kilometers this month", Target = 3, Progress = 1 },
                new Goal { Id = Guid.NewGuid(), UserId = customerUser.Id, Description = "Lose 2 kg in 2 months", Target = 2, Progress = 1 }
            };

        }
    }
}
