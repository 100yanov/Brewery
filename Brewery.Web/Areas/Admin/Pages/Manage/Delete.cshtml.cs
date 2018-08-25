using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Brewery.Core.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Brewery.Web.Areas.Admin.Pages.Manage
{
    [Authorize(Roles = Roles.Admin)]
    public class DeleteModel : PageModel
    {
        private readonly UserManager<IdentityUser> userManager;
        public DeleteModel(UserManager<IdentityUser> userManager)
        {
            this.userManager = userManager;
        }
        public async Task OnGet(string id)
        {
            var user = await this.userManager.FindByIdAsync(id);
            this.Username = user.UserName;
        }
        public async Task<IActionResult> OnPost(string id)
        {
            var user = await this.userManager.FindByIdAsync(id);
            if (user!=null)
            {
                 await this.userManager.DeleteAsync(user);
            }
           

            return RedirectToPage("Index");
        }
        

        public string Username { get; set; }
    }
}