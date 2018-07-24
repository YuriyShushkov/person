using System.Data.Entity;

namespace Person.Models
{
	public class PersonContext: DbContext
	{
		public PersonContext() : base("Persons")
		{ }

		
		public DbSet<Person> Persons { get; set; }		
	}
}