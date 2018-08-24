using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;

using System.Linq;
using Microsoft.EntityFrameworkCore;
using Brewery.Models;
using Brewery.Core.Constants;

namespace Brewery.Data
{
    public class DbSeed
    {
        private readonly IServiceProvider services;


        public DbSeed(IServiceProvider services)
        {
            this.services = services;
        }
        public void Seed()
        {
            using (var serviceScope = this.services.CreateScope())
            {
                BreweryDbContext context = serviceScope
                    .ServiceProvider.GetService<BreweryDbContext>();

                context.Database.Migrate();

                RoleManager<IdentityRole<Guid>> roleManager =
                    serviceScope
                    .ServiceProvider
                    .GetService<RoleManager<IdentityRole<Guid>>>();

                UserManager<User> userManager =
                    serviceScope.ServiceProvider.GetService<UserManager<User>>();

                EnsureAdminUser(roleManager, userManager);

                // context.SaveChanges(); //does nothing
            }
        }

        private static void EnsureAdminUser(RoleManager<IdentityRole<Guid>> roleManager, UserManager<User> userManager)
        {
            var roleResult = roleManager
               .CreateAsync(new IdentityRole < Guid > (Roles.Admin))
               .Result;

            var clientRoleResult = roleManager
               .CreateAsync(new IdentityRole<Guid>(Roles.Employee))
               .Result;

            if (userManager.Users.Any())
            {
                return;
            }

            User admin = new User()
            {
                //FirstName = "Admin",
                //LastName = "Admin",
                UserName = "admin",
                Email = "admin@test.tst"
            };


            var userResult = userManager
             .CreateAsync(admin, "Pass12!")
             .Result;

            var adminUser = userManager
                  .AddToRoleAsync(admin, Roles.Admin)
                  .Result;

        }
    }
}
