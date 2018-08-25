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
		//public override RecipeDomModel Find( Guid id )
		//{
		//	var entity = this.EntitySet.Include(e => e.Ingredients).FirstOrDefault(e => e.Id == id);
		//	var result = this.EntityToDomain(entity);
		//	return result;
		//}
		public override void Edit( RecipeDomModel domObj )
		{
			var recipe = this.EntitySet.Include(e => e.Ingredients).FirstOrDefault(r => r.Id == domObj.Id);
			var ingredients = domObj.Ingredients.Select(i => new IngredientForRecipe { IngredientId = i.Id, RecipeId = domObj.Id, RequiredAmmount = i.Quantity }).ToList();
			//this.Context.IngredientsForRecipe.UpdateRange(recipe.Ingredients);
			recipe.Name = domObj.Name;
			recipe.Description = domObj.Description;
			recipe.Ingredients = ingredients;
			this.EntitySet.Update(recipe);

			Context.SaveChanges();
		}
		//public override IEnumerable<RecipeDomModel> GetAll()
		//{
		//	var recipesWithIngredients = this.EntitySet.Include(e => e.Ingredients);
		//	var domRecipes = this.EntityToDomainCollection(recipesWithIngredients);
		//	return domRecipes;
		//}
		
		protected override Recipe DomainToEntity( RecipeDomModel domObj )
		{
			
			var recipeEntity = new Recipe
			{
                Id=domObj.Id,
				Name = domObj.Name,
				Description = domObj.Description,
				Ingredients = domObj
				.Ingredients
				.Select(i => new IngredientForRecipe
				{
					IngredientId = i.Id,
					RecipeId= domObj.Id,
					RequiredAmmount = i.Quantity
				})
				.ToList(),
			};
			return recipeEntity;
		}

		public int GetBrewsCount(Guid id)
        {
            return this.Context.Brews.Where(b => b.RecipeId == id).ToList().Count;
        }

        protected override IEnumerable<RecipeDomModel> EntitiesToDomain( IQueryable<Recipe> entities )
		{
			var modelCollection = new List<RecipeDomModel>();
			entities = entities.Include(e => e.Brews).Include(e => e.Ingredients).ThenInclude(i=>i.Ingredient);

			foreach (var e in entities)
			{
				var model = new RecipeDomModel()
				{
					Id = e.Id,
					Name = e.Name,
					Description = e.Description,
					Ingredients = IngredientToDom(e.Ingredients),
					//todo: add brews?
				};
				modelCollection.Add(model);
			}

			return modelCollection;
		}

		private ICollection<IngredientDomModel> IngredientToDom( ICollection<IngredientForRecipe> ingredients )
		{
			var ingredientModels = new List<IngredientDomModel>();
			foreach (var i in ingredients)
			{
				var ingredient = new IngredientDomModel
				{
					Id = i.IngredientId,
					Name = i.Ingredient.Name,
					Quantity = i.RequiredAmmount
				};

				ingredientModels.Add(ingredient);
			}
			return ingredientModels;
		}
	}
}

