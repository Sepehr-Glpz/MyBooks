namespace Models
{
    [System.ComponentModel.DataAnnotations.Schema.Table
        (name: "Library Books")]
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

                Property(current => current.WriterName)
                    .IsOptional()
                    .HasMaxLength(20)
                    .IsVariableLength()
                    .IsUnicode();

                Property(current => current.PublishYear)
                    .IsOptional();

                Property(current => current.Description)
                    .IsOptional()
                    .HasMaxLength(1024)
                    .IsVariableLength()
                    .IsUnicode();

                Property(current => current.OwnerUserId)
                     .IsOptional();
            }
        }
        #endregion /Configuration
        public Book() : base()
        {

        }
        [System.ComponentModel.DataAnnotations.Schema.
            Column(name:"Name")]
        [System.ComponentModel.DataAnnotations.
            Display(ResourceType = typeof(Resources.DataDictionary),
            Name = nameof(Resources.DataDictionary.LocalBookName))]
        [System.ComponentModel.DataAnnotations.
            Required(AllowEmptyStrings = false,
            ErrorMessageResourceType = typeof(Resources.ErrorMessages),
            ErrorMessageResourceName = nameof(Resources.ErrorMessages.NameRequiredError))]
        [System.ComponentModel.DataAnnotations.
            StringLength(maximumLength: 20, MinimumLength = 2,
            ErrorMessageResourceType = typeof(Resources.ErrorMessages),
            ErrorMessageResourceName = nameof(Resources.ErrorMessages.NameLengthError))]
        public string BookName { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.
            Column(name:"Author")]
        [System.ComponentModel.DataAnnotations.
            Display(ResourceType = typeof(Resources.DataDictionary),
            Name = nameof(Resources.DataDictionary.LocalWriterName))]
        [System.ComponentModel.DataAnnotations.
            StringLength(maximumLength: 20, MinimumLength = 3,
            ErrorMessageResourceType = typeof(Resources.DataDictionary),
            ErrorMessageResourceName = nameof(Resources.ErrorMessages.WriterNameLengthError))]

        public string WriterName { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.
            Column(name: "Year")]
        [System.ComponentModel.DataAnnotations.
            Display(ResourceType = typeof(Resources.DataDictionary),
            Name = nameof(Resources.DataDictionary.LocalPublishYear))]
        [System.ComponentModel.DataAnnotations.
            Range(type: typeof(int), minimum: "0", maximum: "10000",
            ErrorMessageResourceType = typeof(Resources.ErrorMessages),
            ErrorMessageResourceName = nameof(Resources.ErrorMessages.PublishYearRangeError))]
        public int PublishYear { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.
            Column(name:"Book Genre")]
        [System.ComponentModel.DataAnnotations.
            Display(ResourceType = typeof(Resources.DataDictionary),
            Name = nameof(Resources.DataDictionary.LocalGenre))]
        [System.ComponentModel.DataAnnotations.
            Required(AllowEmptyStrings = false,
            ErrorMessageResourceType = typeof(Resources.ErrorMessages),
            ErrorMessageResourceName = nameof(Resources.ErrorMessages.GenreError))]
        public BookGenres Genre { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.
            Column(name: "Book Type")]
        [System.ComponentModel.DataAnnotations.
            Display(ResourceType = typeof(Resources.DataDictionary),
            Name = nameof(Resources.DataDictionary.LocalBookType))]
        [System.ComponentModel.DataAnnotations.
            Required(AllowEmptyStrings = false,
            ErrorMessageResourceType = typeof(Resources.ErrorMessages),
            ErrorMessageResourceName = nameof(Resources.ErrorMessages.BookTypeError))]
        public BookType BookType { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.
            Column(name: "Description")]
        [System.ComponentModel.DataAnnotations.
            Display(ResourceType = typeof(Resources.DataDictionary),
            Name = nameof(Resources.DataDictionary.LocalBookDescription))]
        [System.ComponentModel.DataAnnotations.
            StringLength(maximumLength: 1024, MinimumLength = 0,
            ErrorMessageResourceType = typeof(Resources.ErrorMessages),
            ErrorMessageResourceName = nameof(Resources.ErrorMessages.BookDescriptionLengthError))]
        public string Description { get; set; }

        [System.ComponentModel.DataAnnotations.
            Display(ResourceType = typeof(Resources.DataDictionary),
            Name = nameof(Resources.DataDictionary.OwnerUser))]
        public virtual User OwnerUser { get; set; }

        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DataAnnotations.
            Display(ResourceType = typeof(Resources.DataDictionary),
            Name = nameof(Resources.DataDictionary.OwnerUserId))]
        public System.Guid OwnerUserId { get; set; }


    }
}
