using HpSubscriptions.Database;

namespace HpSubscriptions
{
    public static class DatabaseConfig
    {
        public static void Configure()
        {
            System.Data.Entity.Database.SetInitializer(new DatabaseInitializer());

            using (var context = new DatabaseContext())
            {
                context.Database.Initialize(true);
            }
        }
    }
}