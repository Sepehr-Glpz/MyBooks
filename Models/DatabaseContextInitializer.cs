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
            Book firstBook = new Book()
            {
                BookName = "Magic Grimoire",
                PublishYear = 2020,
                WriterName = "UnKnown",
                Genre = BookGenres.Other,
                BookType = BookType.Other,
                Description =
                $"The first ever book in the database, owned by the system admin,{System.Environment.NewLine}" +
                $"grants the power to rule all other books and users.",
            };
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
            firstBook.OwnerUser = firstUser;
            firstBook.OwnerUserId = firstUser.Id;
            firstUser.FullName.FirstName = "Sepehr";
            firstUser.FullName.LastName = "golpazir";
            firstUser.Books = new System.Collections.Generic.List<Book>();
            firstUser.Books.Add(firstBook);
            dummy.FullName.FirstName = "sir dummy";
            dummy.FullName.LastName = "The great";
            dummy.Books = new System.Collections.Generic.List<Book>();
            databaseContext.Users.Add(firstUser);
            databaseContext.Books.Add(firstBook);
            databaseContext.Users.Add(dummy);
            databaseContext.Books.Add(testBook);
            databaseContext.SaveChanges();
        }


    }
}
