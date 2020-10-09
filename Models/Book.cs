namespace Models
{
    [System.ComponentModel.DataAnnotations.Schema.Table
        (name:nameof(Resources.DataDictionary.Book))]
    public class Book : BaseEntity
    {
        #region Configuration
        internal class Configuration :
            System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Book>
        {
            public Configuration() : base()
            {
                HasOptional(current => current.OwnerUser)
                     .WithMany(user => user.Books)
                     .HasForeignKey(current => current.OwnerUserId)
                     .WillCascadeOnDelete(false);

                Property(current => current.BookName)
                    .HasMaxLength(20)
                    .IsVariableLength()
                    .IsUnicode();
                    

            }
        }
        #endregion /Configuration
        public Book() : base()
        {
           
        }
        [System.ComponentModel.DataAnnotations.Schema.
            Column(name:nameof(Resources.DataDictionary.BookName))]
        [System.ComponentModel.DataAnnotations.
            Display(Name =nameof(Resources.DataDictionary.LocalBookName))]
        [System.ComponentModel.DataAnnotations.
            Required(AllowEmptyStrings =false,ErrorMessage =nameof(Resources.ErrorMessages.NameRequiredError))]
        [System.ComponentModel.DataAnnotations.
            StringLength(maximumLength:20,MinimumLength =2,ErrorMessage =nameof(Resources.ErrorMessages.NameLengthError))]
        public string BookName { get; set; }

        public string WriterName { get; set; }

        public int PublishYear { get; set; }

        public BookGenres Genre { get; set; }

        public BookType BookType { get; set; }

        public string Description { get; set; }

        public virtual User OwnerUser { get; set; }

        public System.Guid OwnerUserId { get; set; }


    }
}
