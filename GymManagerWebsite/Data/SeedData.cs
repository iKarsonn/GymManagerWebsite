using Microsoft.AspNetCore.Identity;

namespace GymManagerWebsite.Data
{
    public static class SeedData
    {
        public static async Task InitializeAsync(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();

            string[] roles = { "Admin", "Member" };

            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role))
                {
                    await roleManager.CreateAsync(new IdentityRole(role));
                }
            }

            string adminEmail = "ogrencinumarasi@sakarya.edu.tr";
            string adminPassword = "sau";

            var adminUser = await userManager.FindByEmailAsync(adminEmail);

            if (adminUser == null)
            {
                adminUser = new IdentityUser
                {
                    UserName = adminEmail,
                    Email = adminEmail,
                    EmailConfirmed = true
                };

                await userManager.CreateAsync(adminUser);               // 1️⃣ kullanıcıyı oluştur
                await userManager.AddPasswordAsync(adminUser, adminPassword); // 2️⃣ şifreyi ekle
                await userManager.AddToRoleAsync(adminUser, "Admin");   // 3️⃣ rol ata
            }
        }
    }
}
