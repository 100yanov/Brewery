using System;
using System.Collections.Generic;

namespace Brewery.Core.DomainModels
{
	public class RecipeDomModel: BaseDomModel<Guid>
	{
		public string Description { get; set; }
		public IEnumerable<IngredientDomModel> Ingredients	{get; set; }
	}
}