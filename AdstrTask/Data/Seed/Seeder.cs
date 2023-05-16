using AdstrTask.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace AdstrTask.Data.Seed
{
    public static class Seeder
    {
        public static void SeedIdentity(ModelBuilder modelBuilder)
        {
            var adminRoleId = Guid.NewGuid().ToString();
            var adminId = Guid.NewGuid().ToString();
            var hasher = new PasswordHasher<IdentityUser>();

            var userRole = new IdentityRole()
            {
                Id = Guid.NewGuid().ToString(),
                Name = AdstrTechStrings.Roles.User,
                NormalizedName = AdstrTechStrings.Roles.User.ToUpper()
            };

            var adminRole = new IdentityRole()
            {
                Id = adminRoleId,
                Name = AdstrTechStrings.Roles.Admin,
                NormalizedName = AdstrTechStrings.Roles.Admin.ToUpper()
            };
            modelBuilder.Entity<IdentityRole>().HasData(adminRole, userRole);


            var admin = new IdentityUser()
            {
                Id = adminId,
                Email = "Ahmadalzean22@com",
                SecurityStamp = Guid.NewGuid().ToString("D"),
                UserName = "Ahmadalzean22@com",
                NormalizedUserName = "AHMADALZEAN22@COM",
                PhoneNumber = "+111111111111",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Ahmad@123")
            };

            modelBuilder.Entity<IdentityUser>().HasData(admin);

            var IdentityRole1 = new IdentityUserRole<string>() { RoleId = adminRoleId, UserId = adminId };

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(IdentityRole1);

        }
    }
}
