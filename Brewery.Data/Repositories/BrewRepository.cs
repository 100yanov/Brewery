using Brewery.Core.Contracts.Repositories;
using Brewery.Core.DomainModels;
using Brewery.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Brewery.Data.Repositories
{
	public class BrewRepository : GenericRepository<BrewDomModel, Brew, Guid>, IBrewRepository
	{
		public BrewRepository( BreweryDbContext contextInjection )
			: base(contextInjection) { }

		public override BrewDomModel Find( Guid id )
		{
			var entity = this.EntitySet.Include(e => e.Recipe).FirstOrDefault(e => e.Id == id);
			var result = this.EntityToDomain(entity);
			return result;
		}
		//public override void Edit( RecipeDomModel domObj )
		//{
		//	var recipe = this.EntitySet.Include(e => e.Recipe).FirstOrDefault(r => r.Id == domObj.Id);
		//	var ingredients = domObj.Ingredients.Select(i => new IngredientForRecipe { IngredientId = i.Id, RecipeId = domObj.Id, RequiredAmmount = i.Quantity }).ToList();
		//	//this.Context.IngredientsForRecipe.UpdateRange(recipe.Ingredients);
		//	recipe.Name = domObj.Name;
		//	recipe.Description = domObj.Description;
		//	recipe.Ingredients = ingredients;
		//	this.EntitySet.Update(recipe);

		//	Context.SaveChanges();
		//}
		

		protected override Brew DomainToEntity( BrewDomModel domObj )
		{
			var brewEntity = new Brew
				{
					Name = domObj.Name,
					Description = domObj.Description,
					RecipeId = domObj.RecipeId
				};

			return brewEntity;
		}

		protected override BrewDomModel EntityToDomain( Brew entity )
		{
			
			var brewDomObj = new BrewDomModel
			{
				Id = entity.Id,
				Name = entity.Name,
				Description = entity.Description,
				RecipeId = entity.RecipeId,
				RecipeName = entity.Recipe.Name
			};
			return brewDomObj;
		}

		protected /*override*/ IEnumerable<BrewDomModel> ProjectEntities( IQueryable<Brew> entities )
		{
			var modelCollection = new List<BrewDomModel>();
			entities = entities.Include(e => e.Recipe);
			foreach (var e in entities)
			{
				var model = new BrewDomModel()
				{
					Id = e.Id,
					Name = e.Name,
					Description = e.Description,
					RecipeName = e.Recipe.Name,
					RecipeId = e.Recipe.Id
				};

				// var model = this.SetProperties(e, new BrewDomModel());

				modelCollection.Add(model);

			}
			return modelCollection;
		}

	}
}
