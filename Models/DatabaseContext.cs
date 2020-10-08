namespace Models
{
    public class DatabaseContext : System.Data.Entity.DbContext
    {
        static DatabaseContext()
        {
            System.Data.Entity.Database.SetInitializer(new DatabaseContextInitializerBeforeFirstRelease());
        }
        public DatabaseContext() : base()
        {

        }




        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
