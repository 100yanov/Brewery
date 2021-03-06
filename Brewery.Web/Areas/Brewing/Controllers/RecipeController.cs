﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Brewery.Core.Contracts.Managers;
using Brewery.Core.DomainModels;
using Brewery.Web.Areas.Brewing.Models.BindingModels;
using Brewery.Web.Areas.Brewing.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Brewery.Web.Areas.Brewing.Controllers
{
    public class RecipeController : AdminController
    {
		private readonly IRecipeManager manager;
		
		public RecipeController(IRecipeManager manager  )
		{
			this.manager = manager;
			
		}
        // GET: Recipe
        public ActionResult Index()
        {
			var model = new RecipeListViewModel();
			var recipeDoms = this.manager.GetAll();
			var modelRecipes = recipeDoms.Select(r => new RecipeViewModel(r));
			model.Recipes = modelRecipes.ToList();

			return View(model);
        }

        // GET: Recipe/Details/5
        public ActionResult Details(Guid id)
        {
			var recipe = this.manager.Find(id);
			var model = new RecipeViewModel(recipe);
            return View(model);
        }

        // GET: Recipe/Create
        public ActionResult Create()
        {
			var availableIngredients = this.manager.GetAvailableIngredients();
			
			var model = new RecipeBindingModel(availableIngredients);

            return View(model);
        }

        // POST: Recipe/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RecipeBindingModel model, string id)
        {
            if (!ModelState.IsValid)
            {
                return View(nameof(Create), id);
            }
            try
            {
				var ingredients = model.Ingredients.Where(i => i.Quantity > 0)
					.Select(i=>new IngredientDomModel
					{
						Id =Guid.Parse(i.Id),
						Quantity = i.Quantity
					});
				var recipeDom = new RecipeDomModel
				{
					Name =model.Name,
					Description =model.Description,
					Ingredients = ingredients.ToList()
				};
				var recipe = this.manager.Add(recipeDom);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Recipe/Edit/5
        public ActionResult Edit(string id)
        {
			var recipe = this.manager.Find(Guid.Parse(id));
			var availableIngredients = this.manager.GetAvailableIngredients()
                .Where(i=>!recipe.Ingredients.Select(ri=>ri.Id)
                .Contains(i.Id)).ToList();
			//recipe.Ingredients.ToList().AddRange(availableIngredients);
            RecipeBindingModel model = new RecipeBindingModel(recipe,availableIngredients);
            return View(model);
        }

        // POST: Recipe/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(RecipeBindingModel model, string id)
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("Error","Error!");
                return RedirectToAction("Edit","Recipe", id);
            }
            try
            {
                var ingredients = model.Ingredients.Where(i => i.Quantity > 0)
                    .Select(i => new IngredientDomModel
                    {
                        Id = Guid.Parse(i.Id),
                        Quantity = i.Quantity,
                    });

                var recipeDom = new RecipeDomModel
                {
                    Id = Guid.Parse(id),
                    Name = model.Name,
                    Description = model.Description,
                    Ingredients = ingredients.ToList()
                };

                this.manager.Edit(recipeDom);

                return RedirectToAction(nameof(Index));
            }
            catch(Exception e)
            {
                ModelState.AddModelError("Error", e.Message);
                return RedirectToAction("Edit", "Recipe", id);
            }
        }

        // GET: Recipe/Delete/5
        public ActionResult Delete(string id)
        {
            var recipe = this.manager.Find(Guid.Parse(id));
            int brewsCount = this.manager.GetBrewsCount(Guid.Parse(id));

            var model = new RecipeDeleteViewModel { Name=recipe.Name, BrewsCount=brewsCount};
            return View(model);
        }

        // POST: Recipe/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Guid id, IFormCollection collection)
        {
            try
            {
                this.manager.Delete(id);

                return RedirectToAction(nameof(Index));
            }
            catch(Exception e)
            {
                
                return View();
            }
        }

		private RecipeDomModel ConvertToDomModel( Guid id, RecipeBindingModel model )
		{
			var result = new RecipeDomModel
			{
				Id = id,
			};
          
            return result;
		}
	}
}