using Brewery.Core.DomainModels;
using System;

namespace Brewery.Core.Contracts.Repositories
{
	public interface IBrewRepository : IRepository<BrewDomModel, Guid>
    {
    }
}
