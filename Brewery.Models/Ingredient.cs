using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Brewery.Models
{
    public class Ingredient : BaseEntity<Guid>
	{
		public Ingredient()
		{
			this.Recipes = new List<IngredientForRecipe>();
		}
        [Required]
        [Range(0,double.MaxValue)]
		public double Quantity { get; set; }

		public ICollection<IngredientForRecipe>Recipes{ get; set; }
	}
}
