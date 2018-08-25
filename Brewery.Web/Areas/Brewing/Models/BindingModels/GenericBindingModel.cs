using Brewery.Core.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Brewery.Web.Areas.Brewing.Models.BindingModels
{
	public abstract class GenericBindingModel<TDomObj,TKey>
		where TKey:struct
		where TDomObj : BaseDomModel<TKey>
	{
		public GenericBindingModel( TDomObj domObj)
		{

		}
	}
}
