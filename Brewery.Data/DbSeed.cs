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

        public void Seed(/*IServiceProvider services*/)
        {
            using (var serviceScope = this.services.CreateScope())
            {
                BreweryDbContext context = serviceScope.ServiceProvider.GetService<BreweryDbContext>();
                context.Database.EnsureCreated();
        
                RoleManager<IdentityRole> roleManager = serviceScope
                    .ServiceProvider
                    .GetService<RoleManager<IdentityRole>>();
                
                UserManager<IdentityUser> userManager = serviceScope.ServiceProvider.GetService<UserManager<IdentityUser>>();
                //if (context.UserRoles.Any())
                //{
                //    return;
                //}
                EnsureAdminUser(roleManager, userManager);
               
               // context.SaveChanges();
            }
        }
        private void EnsureAdminUser(RoleManager<IdentityRole> roleManager, UserManager<IdentityUser> userManager)
        {
            IdentityUser admin = new IdentityUser() { UserName = "Admin@test.tst", Email = "Admin@test.tst" };
            var userResult = userManager.CreateAsync(admin, "Pass123").Result;
            var adminRoleResult = roleManager.CreateAsync(new IdentityRole(Roles.Admin)).Result;
            var employeeRoleResult = roleManager.CreateAsync(new IdentityRole(Roles.Employee)).Result;
            IdentityUser newUser = userManager.FindByEmailAsync(admin.Email).Result;
            var adminUser = userManager.AddToRoleAsync(newUser, Roles.Admin).Result;
        }
    }
}
