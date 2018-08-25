using Brewery.Core.Contracts.Managers;
using Brewery.Core.Contracts.Repositories;
using Brewery.Data;
using Brewery.Data.Repositories;
using Brewery.Models;
using Brewery.Services.Managers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Brewery.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddDbContext<BreweryDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
       
            services
               .AddIdentity<IdentityUser, IdentityRole>(
                o => 
                {
                    o.Password.RequireDigit = true;
                    o.Password.RequiredLength=6;
                 }
                
                )
               .AddDefaultUI()
               .AddDefaultTokenProviders()
               .AddEntityFrameworkStores<BreweryDbContext>();

           ;

            AddRepositories(services);
            AddManagers(services);

            services.AddTransient<DbSeed>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, DbSeed seed)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

           

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
               
                routes.MapRoute(
                    name: "area",
                    template: "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
            seed.Seed();
        }
        private static void AddManagers(IServiceCollection services)
        {
            services.AddScoped<IIngredientManager, IngredientManager>();
            services.AddScoped<IRecipeManager, RecipeManager>();
            services.AddScoped<IBrewManager, BrewManager>();
        }

        private static void AddRepositories(IServiceCollection services)
        {
            services.AddScoped<IIngredientRepository, IngredientRepository>();
            services.AddScoped<IRecipeRepository, RecipeRepository>();

            services.AddScoped<IBrewRepository, BrewRepository>();
        }


    }
}
