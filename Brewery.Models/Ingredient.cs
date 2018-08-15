using System;
using System.Collections.Generic;

namespace Brewery.Models
{
    public class Ingredient : BaseEntity<Guid>
	{
		public Ingredient()
		{
			this.Recipes = new List<IngredientForRecipe>();
		}
		public double Quantity { get; set; }
		public ICollection<IngredientForRecipe>Recipes{ get; set; }
	}
}
