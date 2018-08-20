using System;
using System.Collections.Generic;
using System.Text;

namespace Brewery.Models
{
    public class Brew: BaseEntity<Guid>
	{
		public string Description { get; set; }
		public Guid RecipeId { get; set; }
		public Recipe Recipe { get; set; }
		//public double  Price { get; set; }
	}
}
