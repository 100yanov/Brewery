﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brewery.Web.Areas.Brewing.Models.ViewModels
{
	public class RecipeListViewModel
	{
		public RecipeListViewModel()
		{

		}
	
		public ICollection<RecipeViewModel> Recipes { get; set; }
	}
}
