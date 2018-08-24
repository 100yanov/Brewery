using Brewery.Core.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brewery.Web.Areas.Admin.Models.ViewModels
{
	public class RecipeViewModel : IdentifiableViewModel<string>
	{
		public RecipeViewModel()
		{
			
		}
		public RecipeViewModel( RecipeDomModel model )
		{
			this.Id = model.Id.ToString();
			this.Name = model.Name;
			this.Description = model.Description;
			if (model.Ingredients!=null)
			{
				this.Ingredients = model.Ingredients.Select(i=>new RecipeIngredientViewModel(i)).ToList();
			}
			
		}
		public string Name { get; set; }
		public string Description { get; set; }
		public ICollection<RecipeIngredientViewModel> Ingredients { get; set; }
	}
}
