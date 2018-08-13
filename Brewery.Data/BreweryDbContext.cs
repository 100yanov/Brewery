using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace Brewery.Data
{
	public class BreweryDbContext : IdentityDbContext<IdentityUser>
	{
		public BreweryDbContext( DbContextOptions options ) 
			: base(options)
		{
		}

	}
}
