using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiboChallenger.Infra.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<Context.NiboChallengerContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;

            //Set to false if do not wish data loss during automatic migration
            AutomaticMigrationDataLossAllowed = true;
        }
        protected override void Seed(Context.NiboChallengerContext context)
        {
            // Useful to initialize insert of data in the databases

        }
    }
}
