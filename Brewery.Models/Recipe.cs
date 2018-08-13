using System;
using System.Collections.Generic;
using System.Text;

namespace Brewery.Models
{
    public class Recipe : BaseEntity
    {
		public Recipe()
		{
			this.Ingredients = new List<Ingredient>();
		}
		public string Description { get; set; }
		public ICollection<Ingredient> Ingredients { get; set; }
	}
}
