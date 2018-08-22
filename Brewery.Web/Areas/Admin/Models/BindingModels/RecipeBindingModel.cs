﻿using Brewery.Core.DomainModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Brewery.Web.Areas.Admin.Models.BindingModels
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
		[BindProperty]
		public string Name { get; set; }

		[Required]
		[BindProperty]
		public string Description { get; set; }

		[Required]
		[BindProperty]
		public List<RecipeIngredientBindingModel> Ingredients{ get; set; }



	}
}