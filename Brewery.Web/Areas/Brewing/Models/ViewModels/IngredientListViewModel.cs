using Brewery.Core.DomainModels;
using System.Collections.Generic;
using System.Linq;

namespace Brewery.Web.Areas.Brewing.Models.ViewModels
{
	public class IngredientListViewModel 
	{
		public IngredientListViewModel()
		{

		}
		public IngredientListViewModel( ICollection<IngredientDomModel> ingredients)
		{
			this.Ingredients = ingredients.Select(i=>new IngredientViewModel(i)).ToArray();
		}

		public ICollection<IngredientViewModel> Ingredients { get; set; }
	}
}
