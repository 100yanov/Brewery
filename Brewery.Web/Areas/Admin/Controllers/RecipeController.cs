using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Brewery.Core.Contracts.Managers;
using Brewery.Core.DomainModels;
using Brewery.Web.Areas.Admin.Models.BindingModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Brewery.Web.Areas.Admin.Controllers
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
            return View();
        }

        // GET: Recipe/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
        public ActionResult Create(RecipeBindingModel model)
        {
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
					Ingredients = ingredients
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
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Recipe/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Recipe/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Recipe/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
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