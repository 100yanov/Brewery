using System.Collections.Generic;
using System.Threading.Tasks;
using Brewery.Core.Contracts.Managers;
using Brewery.Core.Contracts.Repositories;
using Brewery.Core.DomainModels;

namespace Brewery.Services.Managers
{
	public abstract class GenericManager<TDomObj, TKey> : IManager<TDomObj, TKey>
		 where TKey : struct
		where TDomObj : BaseDomModel<TKey>
	{
		protected IRepository<TDomObj, TKey> repository;
		public GenericManager( IRepository<TDomObj, TKey> repository )
		{
			this.repository = repository; 
		}

		public TKey Add( TDomObj domObj )
		{
			return this.repository.Add(domObj);
		}

		public async Task<TKey> AddAsync( TDomObj domObjs )
		{
			return await this.repository.AddAsync(domObjs);
		}

		public void AddRange( IEnumerable<TDomObj> domObjs )
		{
			 this.repository.AddRange(domObjs);
		}

		public async Task<int> AddRangeAsync( IEnumerable<TDomObj> domObjs )
		{
			return await this.repository.AddRangeAsync(domObjs);
		}

		public void Delete( TKey id )
		{
			this.repository.Delete(id);
		}

		public async Task<int> DeleteAsync( TKey id )
		{
			return await this.repository.DeleteAsync(id);
		}

		public void DeleteRange( IEnumerable<TKey> ids )
		{
			this.repository.DeleteRange(ids); 
		}

		public async Task<int> DeleteRangeAsync( IEnumerable<TKey> ids )
		{
			return await this.repository.DeleteRangeAsync(ids);
		}

		public void Edit( TDomObj domObj )
		{
			this.repository.Edit(domObj);
		}

		public async Task<int> EditAsync( TDomObj domObj )
		{
			return await this.repository.EditAsync(domObj); 
		}

		public IEnumerable<TDomObj> GetAll()
		{
			return this.repository.GetAll();
		}

	
		public TDomObj Find( TKey id )
		{
			var domObj = this.repository.Find(id);
		
			return domObj;
		}
		
	}
}
