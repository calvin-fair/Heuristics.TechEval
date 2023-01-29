using System;
using System.Data.Entity.Migrations;
using Heuristics.TechEval.Core.Models;

namespace Heuristics.TechEval.Core.Migrations
{
	internal sealed class Configuration : DbMigrationsConfiguration<DataContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.

	        context.Members.AddOrUpdate(
		        new Member { Email = "sjohnson@heuristics.net", Name = "Seth Petry-Johnson", LastUpdated = new DateTime(2023, 1, 1, 9, 0, 0) },
		        new Member { Email = "sreed@heuristics.net", Name = "Scott Reed", LastUpdated = new DateTime(2023, 1, 2, 9, 0, 0) },
		        new Member { Email = "mfeimster@heuristics.net", Name = "Mike Feimster", LastUpdated = new DateTime(2023, 1, 3, 9, 0, 0) },
                new Member { Email = "bphipps@heuristics.net", Name = "Justin Brown", LastUpdated = new DateTime(2023, 1, 4, 9, 0, 0) }
            );

	        context.Categories.AddOrUpdate(
		        new Category {Name = "Software Developer"},
		        new Category {Name = "Director of Application Development"}
	        );
        }
    }
}
