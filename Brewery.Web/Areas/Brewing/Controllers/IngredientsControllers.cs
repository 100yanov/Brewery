using Brewery.Core.Contracts.Managers;
using Brewery.Core.DomainModels;
using Brewery.Web.Areas.Brewing.Models.BindingModels;
using Brewery.Web.Areas.Brewing.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brewery.Web.Areas.Brewing.Controllers
{//admin/ingredients

	public class IngredientsController : AdminController
	{
		private readonly IIngredientManager manager;
		public IngredientsController( IIngredientManager manager )
		{
			this.manager = manager;
		}

		// GET: Ingredients
		[HttpGet]
		public ActionResult Index()
		{
			var ingredients = this.manager.GetAll();
			var model = new IngredientListViewModel(ingredients.ToList());

			return View(model);
		}

		// GET: Ingredients/Details/5
		public ActionResult Details( Guid id )
		{
			var ingredient = this.manager.Find(id);

			var model = new IngredientViewModel(ingredient);

			return View(model);
		}

		[HttpGet]
		public ActionResult Create()
		{
			return View();
		}

		// POST: Ingredients/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create( IngredientBindingModel model ) //IFormCollection collection
		{
			if (!ModelState.IsValid)
			{
				return View();
			}
			try
			{
				var ingredientDomModel = new IngredientDomModel
                {
                    Name = model.Name,
                    Quantity = model.Quantity
                };

				var result = this.manager.Add(ingredientDomModel);

				return RedirectToAction(nameof(Index));
			}
			catch (Exception e)
			{
				ModelState.AddModelError("Error", e.Message);
				return View();
			}
		}

		// GET: Ingredients/Edit/5
		public ActionResult Edit( Guid id )
		{
			var entity = manager.Find(id);
			var model = new IngredientBindingModel(entity);

			return View(model);
		}

		// POST: Ingredients/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit( Guid id, IngredientBindingModel model )
		{
            if (!ModelState.IsValid)
            {
                return View(nameof(Edit), id);
            }
            try
			{
				IngredientDomModel ingredient = this.ConvertToDomModel(id,model);
				this.manager.Edit(ingredient);

				return RedirectToAction(nameof(Index));
			}
			catch (Exception e)
			{
				ModelState.AddModelError("Error", e.Message);
				return View();
			}
		}
		

		// GET: Ingredients/Delete/5
		[HttpGet]
		public ActionResult Delete( Guid id )
		{

            int recipesCount = this.manager.GetRecipesCount(id);
            var ingredient = this.manager.Find(id);
            var model = new IngredientDeleteViewModel
            {
                Name =ingredient.Name,
                RecipesCount =recipesCount
            };
            
			return View(model);
		}

		// POST: Ingredients/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete( Guid id, IFormCollection collection )
		{
			if (!ModelState.IsValid)
			{
				return View();
			}
			try
			{
				this.manager.Delete(id);
				return RedirectToAction(nameof(Index));
			}
			catch (Exception e)
			{
				ModelState.AddModelError("Error", e.Message);
				return View();
			}
		}
		private IngredientDomModel ConvertToDomModel( Guid id, IngredientBindingModel model )
		{
			var result = new IngredientDomModel
			{
				Id = id,
				Name = model.Name,
				Quantity = model.Quantity
			};
			return result;
		}
	}
}