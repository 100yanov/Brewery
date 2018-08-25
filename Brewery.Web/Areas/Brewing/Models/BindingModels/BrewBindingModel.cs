using Brewery.Core.DomainModels;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Brewery.Web.Areas.Brewing.Models.BindingModels
{
	public class BrewBindingModel
	{
		public BrewBindingModel()
		{

		}
		public BrewBindingModel( BrewDomModel domObj, SelectList recipes )
		{
			this.Name = domObj.Name;
			this.Description = domObj.Description;
			this.RecipeId = domObj.RecipeId.ToString();
			this.RecipeName = domObj.RecipeName;
			this.Recipes = recipes;
		}
		public string Id { get; set; }

		[Required]
        [MaxLength ( 50)]
		public string Name { get; set; }

		[DataType(DataType.MultilineText)]
        [MaxLength(250)]
        public string Description { get; set; }

        [MaxLength(50)]
        public string RecipeName { get; set; }

		[Required]
		public string RecipeId { get; set; }

		public SelectList Recipes { get; set; }
	}
}
