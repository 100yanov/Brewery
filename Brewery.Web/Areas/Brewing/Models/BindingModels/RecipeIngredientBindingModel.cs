using Brewery.Core.DomainModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Brewery.Web.Areas.Brewing.Models.BindingModels
{
	public class RecipeIngredientBindingModel
	{
		public RecipeIngredientBindingModel()
		{

		}
		public RecipeIngredientBindingModel( IngredientDomModel ingredient )
		{
			this.Name = ingredient.Name;
			this.Id = ingredient.Id.ToString();
			this.Quantity = ingredient.Quantity;
		}

		[MaxLength]
		public string Name { get; set; }

		public string Id { get; set; }

		[Required]
		[Range(0, double.MaxValue)]
		public double Quantity { get; set; }

	}
}
