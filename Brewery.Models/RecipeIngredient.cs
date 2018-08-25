using System;
using System.Collections.Generic;
using System.Text;

namespace Brewery.Models
{
    public class IngredientForRecipe
    {
		public Guid IngredientId { get; set; }
		public virtual Ingredient Ingredient { get; set; }

        public Guid RecipeId { get; set; }
		public virtual Recipe Recipe { get; set; }

		public double RequiredAmmount { get; set; }
	}
}
