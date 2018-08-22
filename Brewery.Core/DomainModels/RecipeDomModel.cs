using System;
using System.Collections.Generic;

namespace Brewery.Core.DomainModels
{
	public class RecipeDomModel: BaseDomModel<Guid>
	{
		public RecipeDomModel()
		{
			this.Ingredients = new List<IngredientDomModel>();
		}
		public string Description { get; set; }
		public ICollection<IngredientDomModel> Ingredients	{get; set; }
	}
}