using System.Linq;

namespace Models
{
    internal static class DatabaseContextInitializer : object
    {
        static DatabaseContextInitializer()
        {
        }


        internal static void Seed(DatabaseContext databaseContext)
        {
            
            Book testBook = new Book()
            {
                BookName = "Testing Manual",
                Genre = BookGenres.Scientific,
                BookType = BookType.Other,
            }; 
            User firstUser = new User()
            {
                Username = "sepiGgaming",
                Password = "1234512345",
                Description = "The Original first Admin, Admin of All Admins, Owner of the grimoire, The master of this program.",
                IsActive = true,
                IsAdmin = true,
                IsSysAdmin = true,
            };
            User dummy = new User()
            {
                Username = "DumyUser",
                Password = "123456",
                Description = "Just a test dummy",
                IsActive = false,
                IsAdmin = false,
                IsSysAdmin = false,
            };
            
            firstUser.FullName.FirstName = "Sepehr";
            firstUser.FullName.LastName = "golpazir";
            firstUser.Books = new System.Collections.Generic.List<Book>();
            dummy.FullName.FirstName = "sir dummy";
            dummy.FullName.LastName = "The great";
            dummy.Books = new System.Collections.Generic.List<Book>();
            databaseContext.Users.Add(firstUser);
            databaseContext.Users.Add(dummy);
            databaseContext.Books.Add(testBook);
            for (int index = 0; index <500; index++)
            {
                Book dumbook = new Book()
                {
                    BookName = $"Dummy Book code: {index}",
                    BookType = BookType.Other,
                    Genre = BookGenres.Other,
                };
                databaseContext.Books.Add(dumbook);
            }

            databaseContext.SaveChanges();
        }


    }
}
