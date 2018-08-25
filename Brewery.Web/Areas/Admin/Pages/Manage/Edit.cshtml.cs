using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Brewery.Core.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Brewery.Web.Areas.Admin.Pages.Manage
{
    [Authorize(Roles = Roles.Admin)]
    public class EditModel : PageModel
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public EditModel(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
        }
        [Required]
        [BindProperty]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [BindProperty]
        [DataType(DataType.Password)]
        public string Password { get; set; }

      
        public SelectList UserRoles { get; set; }

        [BindProperty]
        [Required]
        public string RoleId { get; set; }


        public async Task OnGet(string id)
        {
            var user = await this.userManager.FindByIdAsync(id);
            this.Email = user.Email;
            
            var roles = this.roleManager.Roles.Select(r => new { r.Id, r.Name });
            UserRoles = new SelectList(roles, "Id", "Name", RoleId);
        }

        public async Task<IActionResult> OnPost(string id)
        {
            var user = await this.userManager.FindByIdAsync(id);
            await userManager.SetEmailAsync(user, Email);
            await userManager.SetUserNameAsync(user, Email);
         
            if (this.Password!=null)
            {
                var hashedPass = userManager.PasswordHasher.HashPassword(user, Password);
                user.PasswordHash = hashedPass;
            }
           
            var role = await roleManager.FindByIdAsync(RoleId);
           
            var allRroles = this.roleManager
                             .Roles
                             .Select(r => r.Name);
          
            foreach (var r in allRroles)
            {
                await this.userManager.RemoveFromRoleAsync(user,r);
            }
               

            await this.userManager.AddToRoleAsync(user, role.Name);

            var result = await this.userManager.UpdateAsync(user);
            return RedirectToPage("Index");
        }

        

    }
}