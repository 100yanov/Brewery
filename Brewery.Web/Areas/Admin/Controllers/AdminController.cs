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
	[Area("Admin")]
	public abstract class AdminController/*<TDomObj, TKey,TBindingModel,TViewModel>*/ : Controller
		//where TKey : struct
		//where TDomObj : BaseDomModel<TKey>
	{
		//private readonly IManager<TDomObj,TKey> manager;

		//public AdminController( IManager<TDomObj, TKey> manager )
		//{
		//	this.manager = manager;
		//}

		//// GET: Ingredients
		//[HttpGet]
		//public ActionResult Index()
		//{
		//	var ingredients = this.manager.GetAll();
		//	var model = new GenericListViewModel<TDomObj,TKey>(ingredients);

		//	return View(model);
		//}

		//// GET: Ingredients/Details/5
		//public ActionResult Details( TKey id )
		//{
		//	var ingredient = this.manager.Find(id);

		//	var model = new GenericListViewModel<TDomObj, TKey>(ingredient);

		//	return View(model);
		//}

		//[HttpGet]
		//public ActionResult Add()
		//{
		//	return View();
		//}

		//// POST: Ingredients/Create
		//[HttpPost]
		//[ValidateAntiForgeryToken]
		//public ActionResult Add( IngredientBindingModel model ) //IFormCollection collection
		//{
		//	try
		//	{
		//		var ingredientDomModel = new IngredientDomModel { Name = model.Name, Quantity = model.Quantity };
		//		var result = this.manager.Add(ingredientDomModel);

		//		return RedirectToAction(nameof(Index));
		//	}
		//	catch (Exception e)
		//	{
		//		ModelState.AddModelError("Error", e.Message);
		//		return View();
		//	}
		//}

		//// GET: Ingredients/Edit/5
		//public ActionResult Edit( TKey id )
		//{
		//	var entity = manager.Find(id);
		//	var model = new IngredientBindingModel(entity);

		//	return View(model);
		//}

		//// POST: Ingredients/Edit/5
		//[HttpPost]
		//[ValidateAntiForgeryToken]
		//public ActionResult Edit( TKey id, IngredientBindingModel model )
		//{
		//	try
		//	{
		//		IngredientDomModel ingredient = this.ConvertToDomModel(id, model);
		//		this.manager.Edit(ingredient);

		//		return RedirectToAction(nameof(Index));
		//	}
		//	catch (Exception e)
		//	{
		//		ModelState.AddModelError("Error", e.Message);
		//		return View();
		//	}
		//}



		//// GET: Ingredients/Delete/5
		//[HttpGet]
		//public ActionResult Delete( TKey id )
		//{
		//	return View();
		//}

		//// POST: Ingredients/Delete/5
		//[HttpPost]
		//[ValidateAntiForgeryToken]
		//public ActionResult Delete( TKey id, IFormCollection collection )
		//{
		//	try
		//	{
		//		this.manager.Delete(id);
		//		return RedirectToAction(nameof(Index));
		//	}
		//	catch (Exception e)
		//	{
		//		ModelState.AddModelError("Error", e.Message);

		//		return View();
		//	}
		//}


		//protected abstract TDomObj ConvertToDomModel( TKey id, TBindingModel<TDomObj, TKey> model );
		
	}
}