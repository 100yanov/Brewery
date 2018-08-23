using System;
using System.Collections.Generic;
using System.Text;

namespace Brewery.Core.DomainModels
{
    public class BrewDomModel: BaseDomModel<Guid>
	{
		public string Description { get; set; }
		public string RecipeName { get; set; }
		public Guid RecipeId { get; set; }
	}
}
