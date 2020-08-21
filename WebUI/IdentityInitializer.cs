using Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUI
{
    public static class IdentityInitializer
    {
        public static async Task SeedData(UserManager<AppUser> userManager,RoleManager<AppRole> roleManager)
        {
            var adminRole = await roleManager.FindByNameAsync("Admin");
            if(adminRole==null)
            {
                await roleManager.CreateAsync(new AppRole { Name = "Admin" });
            }

            var adminUser = await userManager.FindByNameAsync("yunus");
            if(adminUser==null)
            {
                AppUser user = new AppUser
                {
                    Kullanici = "yunuss",
                    UserName="yunus",
                    Email="e.yunussandikcii@gmail.com"
                };
                await userManager.CreateAsync(user, "1");
                await userManager.AddToRoleAsync(user, "Admin");
            }
        }
    }
}
