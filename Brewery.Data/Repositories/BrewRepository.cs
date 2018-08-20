using Brewery.Core.Contracts.Repositories;
using Brewery.Core.DomainModels;
using Brewery.Models;
using System;


namespace Brewery.Data.Repositories
{
	public class BrewRepository : GenericRepository<BrewDomModel, Brew, Guid>, IBrewRepository
	{
		public BrewRepository( BreweryDbContext contextInjection )
			: base(contextInjection) { }
		

		protected override Brew DomainToEntity( BrewDomModel domObj )
		{
			var brewEntity = new Brew
				{
					Name = domObj.Name,
					Description = domObj.Description,
					RecipeId = domObj.RecipeId
				};

			return brewEntity;
		}

		protected override BrewDomModel EntityToDomain( Brew entity )
		{
			var brewDomObj = new BrewDomModel
			{
				Id = entity.Id,
				Name = entity.Name,
				Description = entity.Description,
				RecipeId = entity.RecipeId,
				RrecipeName = entity.Recipe.Name
			};
			return brewDomObj;
		}


	}
}
