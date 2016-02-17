using System.Data.Entity;

namespace HpSubscriptions.Database
{
    public class DatabaseInitializer: DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
         
    }
}