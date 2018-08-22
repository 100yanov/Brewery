using Brewery.Core.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brewery.Web.Areas.Admin.Models.ViewModels
{
	public class IngredientViewModel : IdentifiableViewModel<string>
	{
		public IngredientViewModel()
		{

		}
		public IngredientViewModel(IngredientDomModel ingredient)
		{
			this.Name = ingredient.Name;
			this.Id =  ingredient.Id.ToString();
			this.Quantity = ingredient.Quantity;
		}
		public string Name { get; set; }
		//public string Id { get; set; }
		public double Quantity { get; set; }

	}
}
