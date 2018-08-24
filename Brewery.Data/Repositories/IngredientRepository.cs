using Brewery.Core.Contracts.Repositories;
using Brewery.Core.DomainModels;
using Brewery.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Brewery.Data.Repositories
{
	public class IngredientRepository : GenericRepository<IngredientDomModel, Ingredient, Guid>, IIngredientRepository
	{
		public IngredientRepository( BreweryDbContext contextInjection ) : base(contextInjection)
		{
		}

		protected override Ingredient DomainToEntity( IngredientDomModel domObj )
		{
			Ingredient ingredientEntity = new Ingredient
			{
				Id = domObj.Id,
				Name = domObj.Name,
				Quantity = domObj.Quantity
			};
			return ingredientEntity;
		}

		protected override IEnumerable<IngredientDomModel> EntitiesToDomain( IQueryable<Ingredient> entities )
		{
			var modelCollection = new List<IngredientDomModel>();

			foreach (var e in entities)
			{
				var model = new IngredientDomModel()
				{
					Id = e.Id,
					Name = e.Name,
					Quantity = e.Quantity,

				};

				modelCollection.Add(model);
			}
			return modelCollection;
		}

		//protected override IngredientDomModel EntityToDomain( Ingredient entity )
		//{
		//	IngredientDomModel ingredientDomModel = new IngredientDomModel
		//	{
		//		Id = entity.Id,
		//		Quantity = entity.Quantity,
		//		Name = entity.Name
		//	};
		//	return ingredientDomModel;
		//}
	}
}
