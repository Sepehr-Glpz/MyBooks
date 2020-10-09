﻿namespace Models
{
    public class Book : BaseEntity
    {
        #region Configuration
        internal class Configuration :
            System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Book>
        {
            public Configuration() : base()
            {



            }
        }
        #endregion /Configuration
        public Book() : base()
        {
           
        }

        public string Name { get; set; }

        public string WriterName { get; set; }

        public int PublishYear { get; set; }

        public BookGenres Genre { get; set; }

        public BookType BookType { get; set; }

        public virtual User OwnerUser { get; set; }

        public System.Guid OwnerId { get; set; }


    }
}
