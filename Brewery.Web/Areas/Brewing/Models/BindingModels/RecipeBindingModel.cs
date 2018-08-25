using Brewery.Core.DomainModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Brewery.Web.Areas.Brewing.Models.BindingModels
{
	public class RecipeBindingModel
	{
		public RecipeBindingModel()
		{
            this.Ingredients = new List<RecipeIngredientBindingModel>();
		}
		public RecipeBindingModel( ICollection<IngredientDomModel> availableIngredients )
            :this()
		{
			this.Ingredients = availableIngredients.Select(i => new RecipeIngredientBindingModel(i)).ToList();
		}
        public RecipeBindingModel(RecipeDomModel model, List<IngredientDomModel> availableIngredients)
            : this()
		{
			this.Name = model.Name;
			this.Description = model.Description;
			//model.Ingredients.Concat(availableIngredients);
			
			this.Ingredients= model.Ingredients.Concat(availableIngredients).Select(i => new RecipeIngredientBindingModel(i)).ToList(); ;
		}

		[Required]
        [MaxLength(50)]
		public string Name { get; set; }

		[Required]
        [MaxLength(250)]
        public string Description { get; set; }

		[Required]
		public List<RecipeIngredientBindingModel> Ingredients{ get; set; }



	}
}
