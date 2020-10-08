namespace Models
{
    internal class DatabaseContextInitializerBeforeFirstRelease : 
        System.Data.Entity.DropCreateDatabaseIfModelChanges<DatabaseContext>
    {
        public DatabaseContextInitializerBeforeFirstRelease() : base()
        {

        }

        protected override void Seed(DatabaseContext databaseContext)
        {
            try
            {
                DatabaseContextInitializer.Seed(databaseContext);
            }
            catch
            {

            }
        }


    }
}
