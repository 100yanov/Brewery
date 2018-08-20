using Brewery.Core.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brewery.Web.Areas.Admin.Models.BindingModels
{
	public class RecipeIngredientListBindingModel
	{
		public RecipeIngredientListBindingModel()
		{

		}
		public RecipeIngredientListBindingModel( IEnumerable<IngredientDomModel> ingredients )
		{
			this.Ingredients = ingredients.Select(i => new RecipeIngredientBindingModel(i)).ToArray();
		}

		public ICollection<RecipeIngredientBindingModel> Ingredients { get; set; }
	}
}

