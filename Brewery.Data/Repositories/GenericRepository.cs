using Brewery.Core.Contracts.Repositories;
using Brewery.Core.DomainModels;
using Brewery.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brewery.Data.Repositories
{
	public abstract class GenericRepository<TDomObj, TEntity, TKey> 
		: IRepository<TDomObj, TKey>
	   where TKey : struct
	   where TEntity : BaseEntity<TKey>, new()
	   where TDomObj : BaseDomModel<TKey>, new()
	{
		protected readonly BreweryDbContext Context;
		protected readonly DbSet<TEntity> EntitySet;
		//private readonly bool disposed;

		public GenericRepository( BreweryDbContext contextInjection )
		{
			Context = contextInjection;
			EntitySet = Context.Set<TEntity>();
		}

		public TKey Add( TDomObj domObj )
		{
			TEntity entity = DomainToEntity(domObj);
			this.EntitySet.Add(entity);
			this.Context.SaveChanges();
			return entity.Id;
		}
		
		public async Task<TKey> AddAsync( TDomObj domObj )
		{
			
			TEntity entity = DomainToEntity(domObj);
			var entityEntry = await this.EntitySet.AddAsync(entity);
			int addedCount=  await this.Context.SaveChangesAsync();

			return entity.Id;
		}

		public void AddRange( IEnumerable<TDomObj> domObjs )
		{
			IEnumerable<TEntity> entities = DomainToEntityCollection(domObjs);

			this.EntitySet.AddRange(entities);

			this.Context.SaveChanges();

		}
				
		public async Task<int> AddRangeAsync( IEnumerable<TDomObj> domObjs )
		{
			IEnumerable<TEntity> entities = DomainToEntityCollection(domObjs);

			 await EntitySet.AddRangeAsync(entities);
			var result = await this.Context.SaveChangesAsync();

			return result;
		}

		public void Delete( TKey id )
		{
			var entity = new TEntity { Id = id };
			this.EntitySet.Remove(entity);
			this.Context.SaveChanges();
		}

		public async Task<int> DeleteAsync( TKey id )
		{
			var entity = new TEntity { Id = id };
			this.EntitySet.Remove(entity);
			var result = await this.Context.SaveChangesAsync();

			return result;
		}

		public void DeleteRange( IEnumerable<TKey> ids )
		{
			
			var domEntities = ids.Select(de=>new TDomObj{ Id=de});
			var entities = this.DomainToEntityCollection(domEntities);
			this.EntitySet.RemoveRange(entities);
			var result = this.Context.SaveChanges();
		}

		public async Task<int> DeleteRangeAsync( IEnumerable<TKey> ids )
		{
			var domEntities = ids.Select(de => new TDomObj { Id = de });
			var entities = this.DomainToEntityCollection(domEntities);
			this.EntitySet.RemoveRange(entities);
			
			var result = await this.Context.SaveChangesAsync();
			return result;
		}

		public virtual void Edit( TDomObj domObj )
		{
			var entity = this.DomainToEntity(domObj);
			this.EntitySet.Update(entity);
			this.Context.SaveChanges();

		}

		public async Task<int> EditAsync( TDomObj domObj )
		{
			var entity = this.DomainToEntity(domObj);
			var entityEntry=   this.EntitySet.Update(entity);
			var result = await this.Context.SaveChangesAsync();

			return result;
		}

		public virtual IEnumerable<TDomObj> GetAll()//todo: add way to get filtered results!
		{
			var entities = this.EntitySet.AsNoTracking().ToArray();
			var domainObjects = this.EntityToDomainCollection(entities);
			return domainObjects;

		}

		public virtual TDomObj Find(TKey id )
		{
			var entity = this.EntitySet.FirstOrDefault(e=>e.Id.Equals(id));
			var domObj = this.EntityToDomain(entity);
			return domObj;
		}
		public async Task <TDomObj> FindAsync( TKey id )
		{
			var entity = await this.EntitySet.FirstOrDefaultAsync(e => e.Id.Equals(id));
			var domObj = this.EntityToDomain(entity);
			return domObj;
		}

		public async Task<IEnumerable<TDomObj>> GetAllAsync() //todo: add way to get filtered results!
		{
			var entities =(await this.EntitySet.AsNoTracking().ToArrayAsync() );
			var domainObjects =  this.EntityToDomainCollection(entities);

			return domainObjects;
		}

	//	protected abstract  IEnumerable< TDomObj> EntityToDomainCollection( IEnumerable<TEntity> entities );
		

		//private methods
		protected abstract TDomObj EntityToDomain(TEntity entity);
		protected IEnumerable<TDomObj>EntityToDomainCollection(IEnumerable<TEntity> entities )
		{
			var collection = entities
				.Select(d => this.EntityToDomain(d))
				.ToArray();
			return collection;
		}

		protected abstract TEntity DomainToEntity( TDomObj domObj );

		protected IEnumerable<TEntity> DomainToEntityCollection( IEnumerable<TDomObj> domObjs )
		{
			var collection = domObjs
				.Select(d => this.DomainToEntity(d))
				.ToArray();
			return collection;
		}
	}
}
