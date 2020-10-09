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

        public System.DateTime PublishYear { get; set; }

        public string Genre { get; set; }



    }
}
