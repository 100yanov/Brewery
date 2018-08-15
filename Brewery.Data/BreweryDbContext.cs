using Brewery.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace Brewery.Data
{
	public class BreweryDbContext : IdentityDbContext<IdentityUser>
	{
		public DbSet<Recipe>Recipes{ get; set; }
		public DbSet<Ingredient> Ingredients { get; set; }
		public DbSet<Brew> Brews { get; set; }
		public DbSet<IngredientForRecipe> IngredientsForRecipe { get; set; }


		public BreweryDbContext( DbContextOptions options ) 
			: base(options)
		{
			
		}

		protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder )
		{
			if (!optionsBuilder.IsConfigured)
			{
				optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=Brewery;Integrated Security=True;");
			}
			base.OnConfiguring(optionsBuilder);
		}

		protected override void OnModelCreating( ModelBuilder builder )
		{
			builder.Entity<Recipe>()
				.HasMany(e => e.Ingredients)
				.WithOne(i => i.Recipe)
				.HasForeignKey(e => e.RecipeId);

			builder.Entity<IngredientForRecipe>().HasKey(ir => new { ir.RecipeId, ir.IngredientId });

			base.OnModelCreating(builder);
		}

	}
}
