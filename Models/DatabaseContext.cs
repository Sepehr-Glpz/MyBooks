namespace Models
{
    public class DatabaseContext : System.Data.Entity.DbContext
    {
        static DatabaseContext()
        {
            //System.Data.Entity.Database.
            //  SetInitializer(new DatabaseContextInitializerBeforeFirstRelease());

            System.Data.Entity.Database.SetInitializer
                      (new System.Data.Entity.MigrateDatabaseToLatestVersion
                           <DatabaseContext, Migrations.Configuration>());
        }
        public DatabaseContext() : base()
        {
            Configuration.LazyLoadingEnabled = true;
        }

        public System.Data.Entity.DbSet<Book> Books { get; set; }

        public System.Data.Entity.DbSet<User> Users { get; set; }


        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Book.Configuration());
            modelBuilder.Configurations.Add(new User.Configuration());
        }
    }
}
