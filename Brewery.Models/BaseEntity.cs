using System;
using System.ComponentModel.DataAnnotations;

namespace Brewery.Models
{
	public abstract class BaseEntity<TKey>
		where TKey: struct
	{
		[Key]
		public TKey Id { get; set; }
		[Required]
		public string Name { get; set; }

	}
}