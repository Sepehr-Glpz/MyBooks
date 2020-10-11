namespace Models
{
    internal static class DatabaseContextInitializer : object
    {
        static DatabaseContextInitializer()
        {
        }


        internal static void Seed(DatabaseContext databaseContext)
        {
            User firstUser = new User()
            {
                Username = "SepiG",
                Password = "1234512345",
                Description = "The Original first Admin",
                IsActive = true,
                IsAdmin = true,
                IsSysAdmin = true,
            };
            firstUser.FullName.FirstName = "Sepehr";
            firstUser.FullName.LastName = "gol";
            firstUser.Books = new System.Collections.Generic.List<Book>();
            databaseContext.Users.Add(firstUser);
            databaseContext.SaveChanges();
        }


    }
}
