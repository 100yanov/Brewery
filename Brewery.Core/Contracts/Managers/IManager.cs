using System.Collections.Generic;
using System.Threading.Tasks;

namespace Brewery.Core.Contracts.Managers
{
	public interface IManager<TDomObj, TKey>
	{
		TDomObj Find( TKey id );

		Task<TDomObj> FindAsync( TKey id );

		IEnumerable<TDomObj> GetAll();

		Task<IEnumerable<TDomObj>> GetAllAsync();

		TKey Add( TDomObj domObj );

		Task<TKey> AddAsync( TDomObj domObjs );

		void AddRange( IEnumerable<TDomObj> domObjs );

		Task<int> AddRangeAsync( IEnumerable<TDomObj> domObjs );

		void Edit( TDomObj domObj );

		Task<int> EditAsync( TDomObj domObj );

		void Delete( TKey id );

		Task<int> DeleteAsync( TKey id );

		void DeleteRange( IEnumerable<TKey> ids );

		Task<int> DeleteRangeAsync( IEnumerable<TKey> ids );
	}
}
