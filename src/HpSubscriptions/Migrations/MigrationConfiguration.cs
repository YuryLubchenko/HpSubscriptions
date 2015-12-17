using System.Data.Entity.Migrations;
using HpSubscriptions.Database;

namespace HpSubscriptions.Migrations
{
    public class MigrationConfiguration : DbMigrationsConfiguration<DatabaseContext>
    {
        public MigrationConfiguration()
        {
            AutomaticMigrationDataLossAllowed = true;
            AutomaticMigrationsEnabled = true;
        }
    }
}