using Brewery.Core.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Brewery.Core.Contracts.Managers
{
	public interface IRecipeManager: IManager<RecipeDomModel,Guid>
	{
		IngredientDomModel[] GetAvailableIngredients();
	}
}
