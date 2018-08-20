using System;

namespace Brewery.Core.DomainModels
{
	public class IngredientDomModel: BaseDomModel<Guid>
	{
		public IngredientDomModel()
		{

		}
		public IngredientDomModel(string name, double quantity)
		{
			this.Name = name;
			this.Quantity = quantity;
		}
		public double Quantity { get; set; }

	}
}