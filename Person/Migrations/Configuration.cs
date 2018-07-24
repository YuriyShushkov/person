using System.Data.Entity.Migrations;

namespace Person.Migrations
{	
	internal sealed class Configuration : DbMigrationsConfiguration<Person.Models.PersonContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Person.Models.PersonContext context)
        {

        }
    }
}
