using System;
using System.Collections.Generic;
using System.Text;

namespace Brewery.Models
{
    public class Recipe : BaseEntity
    {
		
		public Recipe()
		{
			this.Ingredients = new List<IngredientForRecipe>();
			this.Brews = new List<Brew>();
		}
		public string Description { get; set; }
		public ICollection<IngredientForRecipe> Ingredients { get; set; }
		public ICollection<Brew> Brews { get; set; }
	}
}
