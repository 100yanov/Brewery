using Brewery.Core.Contracts.Repositories;
using Brewery.Core.DomainModels;
using Brewery.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Brewery.Data.Repositories
{
	public class RecipeRepository : GenericRepository<RecipeDomModel, Recipe, Guid>, IRecipeRepository
	{
		public RecipeRepository( BreweryDbContext contextInjection )
			: base(contextInjection)
		{
		}

		public IngredientDomModel[] GetAvailableIngredients()
		{
			var availableIngredients = this.Context.Ingredients
				.Select(i=>new IngredientDomModel{ Name=i.Name, Id=i.Id, Quantity=0}).ToArray();
			return availableIngredients;
		}

		public override IEnumerable<RecipeDomModel> GetAll()
		{
			var recipesWithIngredients = this.EntitySet.Include(e => e.Ingredients);
			var domRecipes = this.EntityToDomainCollection(recipesWithIngredients);
			return domRecipes;
		}

		protected override Recipe DomainToEntity( RecipeDomModel domObj )
		{
			
			var recipeEntity = new Recipe
			{

				Name = domObj.Name,
				Description = domObj.Description,
				Ingredients = domObj
				.Ingredients
				.Select(i => new IngredientForRecipe
				{
					IngredientId = i.Id,
					RequiredAmmount = i.Quantity
				})
				.ToList(),
			};
			return recipeEntity;
		}

		protected override RecipeDomModel EntityToDomain( Recipe entity )
		{
			var recipeDomModel = new RecipeDomModel
			{
				Id = entity.Id,
				Name = entity.Name,
				Description = entity.Description,
				Ingredients = entity.Ingredients
				  .Select(i => new IngredientDomModel
				  {
					  Name = i.Ingredient.Name,
					  Id = i.IngredientId,
					  Quantity = i.RequiredAmmount,
				  })
					  .ToList(),
			};
			return recipeDomModel;
		}
	}
}

