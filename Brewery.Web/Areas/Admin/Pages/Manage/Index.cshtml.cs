using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Brewery.Core.Constants;
using Brewery.Web.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Brewery.Web.Areas.Admin.Pages.Manage
{
    [Authorize(Roles = Roles.Admin+","+Roles.Employee)]
    public class IndexModel : PageModel
    {
        private readonly UserManager<IdentityUser> userManager;
      //  private readonly RoleManager<IdentityRole> roleManager;
        public IndexModel(UserManager<IdentityUser> userManager/*, RoleManager<IdentityRole> roleManager*/)
        {
          //  this.roleManager = roleManager;
            this.userManager = userManager;
        }
        public void OnGet()
        {
            var claims = User.Claims.ToList();
           
            var users =  this.userManager.Users
                //.Select(u => new { u.Id, u.UserName })
                .Where(u => u.UserName != this.User.Identity.Name)
                .ToList();
           
            var roles =  users.Select((u,r)=> userManager.GetRolesAsync(u).Result)
                ;
            Users =  users.Select(u => new UserViewModel
            {
                Id = u.Id,
                Username = u.UserName,
                Role = userManager
               .GetRolesAsync(u)
               .Result
               .SingleOrDefault()
               .ToString()
            }).ToList();
            //var roles = this.roleManager.Roles.Where(r=>r.);
          

        }
       // [BindProperty]
        public ICollection<UserViewModel> Users { get; set; }

   
    }
}