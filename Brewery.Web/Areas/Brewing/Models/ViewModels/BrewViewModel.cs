﻿using Brewery.Core.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brewery.Web.Areas.Brewing.Models.ViewModels
{
	public class BrewViewModel : IdentifiableViewModel<string>
	{
		public BrewViewModel()
		{

		}
		public BrewViewModel(BrewDomModel model)
		{
			this.Id = model.Id.ToString();
			this.Name = model.Name;
			this.Description = model.Description;
			this.RecipeName = model.RecipeName;
		}
		public string Name { get; set; }
		public string Description { get; set; }
		public string RecipeName { get; set; }
	}
}
