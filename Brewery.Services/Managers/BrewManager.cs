using Brewery.Core.Contracts.Managers;
using Brewery.Core.Contracts.Repositories;
using Brewery.Core.DomainModels;
using System;

namespace Brewery.Services.Managers
{
	public class BrewManager : GenericManager<BrewDomModel, Guid>, IBrewManager
	{
		public BrewManager( IBrewRepository repository ) 
			: base(repository)
		{
		}
	}
}
