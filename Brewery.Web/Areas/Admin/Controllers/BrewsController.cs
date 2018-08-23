using Brewery.Core.Contracts.Managers;
using Brewery.Core.DomainModels;
using Brewery.Web.Areas.Admin.Models.BindingModels;
using Brewery.Web.Areas.Admin.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brewery.Web.Areas.Admin.Controllers
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
		public ActionResult Details( int id )
		{
			return View();
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
		public ActionResult Edit( int id )
		{
			return View();
		}

		// POST: Brews/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit( int id, IFormCollection collection )
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

		// GET: Brews/Delete/5
		public ActionResult Delete( int id )
		{
			return View();
		}

		// POST: Brews/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete( int id, IFormCollection collection )
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
	}
}