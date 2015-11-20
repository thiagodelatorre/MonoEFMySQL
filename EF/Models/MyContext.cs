using System;
using System.Data.Entity;

namespace EF
{
	public class MyContext : DbContext
	{
		public DbSet<Person> Persons {get;set;}
	}
}

