using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Brewery.Models
{
    public class Brew: BaseEntity<Guid>
	{
        [MaxLength(500)]
		public string Description { get; set; }

        [Required]
        public Guid RecipeId { get; set; }

		public Recipe Recipe { get; set; }
	
	}
}
