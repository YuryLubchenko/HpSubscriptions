using System.Data.Entity;
using HpSubscriptions.Migrations;

namespace HpSubscriptions.Database
{
    public class DatabaseInitializer: MigrateDatabaseToLatestVersion<DatabaseContext, MigrationConfiguration>
    {
         
    }
}