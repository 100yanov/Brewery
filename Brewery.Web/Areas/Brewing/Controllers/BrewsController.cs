using Brewery.Core.Contracts.Managers;
using Brewery.Core.DomainModels;
using Brewery.Web.Areas.Brewing.Models.BindingModels;
using Brewery.Web.Areas.Brewing.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brewery.Web.Areas.Brewing.Controllers
{
	public class BrewsController : AdminController
	{
		private readonly IBrewManager manager;
		private readonly IRecipeManager recipeManager;
		public BrewsController( IBrewManager manager, IRecipeManager recipeManager )
		{
			this.manager = manager;
			this.recipeManager = recipeManager;
		}
		// GET: Brews
		public ActionResult Index()
		{
			var brews = this.manager.GetAll();
			var model = brews.Select(b => new BrewViewModel(b)).ToArray();
			return View(model);
		}

		// GET: Brews/Details/5
		public ActionResult Details( string id )
		{
			var domModel = this.manager.Find(Guid.Parse(id));
			var model = new BrewViewModel
			{
				Id= id,
				Name = domModel.Name,
				Description = domModel.Description,
				RecipeName = domModel.RecipeName
			};

			return View(model);
		}

		// GET: Brews/Create
		public ActionResult Create()
		{

			var model = new BrewBindingModel();

			var recipes = this.recipeManager.GetAll();

			SelectList listItems = new SelectList(recipes, "Id", "Name", model.RecipeId);

			model = new BrewBindingModel(new BrewDomModel(), listItems);
			return View(model);
		}



		// POST: Brews/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create( BrewBindingModel model )
		{
            if (!ModelState.IsValid)
            {
                return View("Index");
            }
            try
			{
				var brew = new BrewDomModel
				{
					Name = model.Name,
					Description = model.Description,
					RecipeId = Guid.Parse(model.RecipeId),
				};

				this.manager.Add(brew);
				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: Brews/Edit/5
		public ActionResult Edit( string id )
		{
			var brew = this.manager.Find(Guid.Parse(id));
			var model = new BrewBindingModel();

			var recipes = this.recipeManager.GetAll();

			SelectList listItems = new SelectList(recipes, "Id", "Name", model.RecipeId);

			model = new BrewBindingModel(brew, listItems);

			return View(model);
		}

		// POST: Brews/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit( BrewBindingModel model, string id)
		{
            if (!ModelState.IsValid)
            {
                return View(nameof(Edit), id);
            }
            try
			{
				BrewDomModel toEdit = new BrewDomModel
				{
					Id = Guid.Parse(id),
					Name = model.Name,
					Description = model.Description,
					RecipeId = Guid.Parse(model.RecipeId)

				};

				this.manager.Edit(toEdit);

				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: Brews/Delete/5
		public ActionResult Delete( string id )
		{
            var brew = this.manager.Find(Guid.Parse(id));
            var model = new BrewViewModel { Name = brew.Name };
            return View(model);
		}

		// POST: Brews/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(BrewViewModel model)
		{
            var id = Guid.Parse( model.Id);
			try
			{
                this.manager.Delete(id);

				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}
	}
}