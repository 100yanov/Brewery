using Brewery.Core.Constants;
using Brewery.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace Brewery.Web.Areas.Admin.Pages.Manage
{
    [Authorize(Roles = Roles.Admin)]
    public class AddModel : PageModel
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public AddModel(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
           
        }

        public void OnGet()
        {
            var roles = this.roleManager.Roles.Select(r => new { r.Id, r.Name });
            this.UserRoles = new SelectList(roles, "Id", "Name", RoleId);
        }

        public async Task<IActionResult> OnPost()
        {
            var user = new IdentityUser
            {
                Email = this.Email,
                UserName = this.Email
            };
            var newUser = await this.userManager.CreateAsync(user, this.Password);
            var role = await roleManager.FindByIdAsync(this.RoleId);
            var roleResult = await this.userManager.AddToRoleAsync(user, role.Name);

            return Page();
        }


        [Required]
        public SelectList UserRoles { get; set; }

        [BindProperty]
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [BindProperty]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [BindProperty]
        [Required]
        [Display(Name = "Role")]
        public string RoleId { get; set; }




        //


        //[BindProperty]


    }
}