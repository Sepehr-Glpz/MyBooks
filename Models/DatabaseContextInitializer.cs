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
            User firstUser = new User()
            {
                Username = "sepiGgaming",
                Password = "1234512345",
                Description = "The Original first Admin, Admin of All Admins, Owner of the grimoire, The master of this program.",
                IsActive = true,
                IsAdmin = true,
                IsSysAdmin = true,
            };
            firstBook.OwnerUser = firstUser;
            firstBook.OwnerUserId = firstUser.Id;
            firstUser.FullName.FirstName = "Sepehr";
            firstUser.FullName.LastName = "golpazir";
            firstUser.Books = new System.Collections.Generic.List<Book>();
            firstUser.Books.Add(firstBook);
            databaseContext.Users.Add(firstUser);
            databaseContext.Books.Add(firstBook);
            databaseContext.SaveChanges();
        }


    }
}
