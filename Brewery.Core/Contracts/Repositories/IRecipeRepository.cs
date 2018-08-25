using Brewery.Core.DomainModels;
using System;

namespace Brewery.Core.Contracts.Repositories
{
	public interface IRecipeRepository : IRepository<RecipeDomModel, Guid>
	{
		IngredientDomModel[] GetAvailableIngredients();
        int GetBrewsCount(Guid id);

    }
}
