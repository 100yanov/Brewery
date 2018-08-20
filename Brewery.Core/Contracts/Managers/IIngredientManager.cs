using Brewery.Core.DomainModels;
using System;

namespace Brewery.Core.Contracts.Managers
{
	public interface IIngredientManager : IManager<IngredientDomModel, Guid>
	{
	}
}
