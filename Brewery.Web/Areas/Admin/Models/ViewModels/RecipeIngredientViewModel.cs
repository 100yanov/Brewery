using Brewery.Core.DomainModels;

namespace Brewery.Web.Areas.Admin.Models.ViewModels
{
	public class RecipeIngredientViewModel : IngredientViewModel
	{
		public RecipeIngredientViewModel()
		{

		}
		public RecipeIngredientViewModel(IngredientDomModel model)
		{
			this.Id = model.Id.ToString();
			this.Name = model.Name;
			this.Quantity = model.Quantity;
		}
		//public string Name { get; set; }
		//public double Quantity  { get; set; }

	}
}