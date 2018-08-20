using Brewery.Core.Contracts.Managers;
using Brewery.Core.Contracts.Repositories;
using Brewery.Core.DomainModels;
using System;

namespace Brewery.Services.Managers
{
	public class RecipeManager : GenericManager<RecipeDomModel, Guid>, IRecipeManager
	{
		public RecipeManager( IRecipeRepository repository ) : base(repository)
		{
		
		}
		public IngredientDomModel[] GetAvailableIngredients()
		{
			var recipeRepo = (IRecipeRepository)this.repository;

			return recipeRepo.GetAvailableIngredients();
		}
	}
}
