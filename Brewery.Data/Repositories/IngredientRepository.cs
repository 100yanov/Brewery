using Brewery.Core.Contracts.Repositories;
using Brewery.Core.DomainModels;
using Brewery.Models;
using System;

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

		protected override IngredientDomModel EntityToDomain( Ingredient entity )
		{
			IngredientDomModel ingredientDomModel = new IngredientDomModel
			{
				Id = entity.Id,
				Quantity = entity.Quantity,
				Name = entity.Name
			};
			return ingredientDomModel;
		}
	}
}
