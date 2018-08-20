using Brewery.Core.Contracts.Managers;
using Brewery.Core.Contracts.Repositories;
using Brewery.Core.DomainModels;
using System;

namespace Brewery.Services.Managers
{
	public class IngredientManager : GenericManager<IngredientDomModel, Guid>, IIngredientManager
	{
		public IngredientManager( IIngredientRepository repository ) 
			: base(repository)
		{
		}
	}
}
