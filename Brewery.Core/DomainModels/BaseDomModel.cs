using System;
using System.Collections.Generic;
using System.Text;

namespace Brewery.Core.DomainModels
{
	public abstract class BaseDomModel<TKey>
	   where TKey : struct
	{
		public TKey Id { get; set; } //todo: check if nullable is better
		public string Name { get; set; }
	}
}
