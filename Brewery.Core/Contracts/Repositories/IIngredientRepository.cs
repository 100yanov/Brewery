using Brewery.Core.DomainModels;
using System;

namespace Brewery.Core.Contracts.Repositories
{
	public interface IIngredientRepository : IRepository<IngredientDomModel, Guid>
	{
        int GetRecipesCount(Guid id);
    }
   
}
