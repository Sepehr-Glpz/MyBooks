﻿namespace Models
{
    [System.ComponentModel.DataAnnotations.Schema.Table
        (name: nameof(Resources.DataDictionary.Book))]
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

            }
        }
        #endregion /Configuration
        public Book() : base()
        {

        }
        [System.ComponentModel.DataAnnotations.Schema.
            Column(name: nameof(Resources.DataDictionary.BookName))]
        [System.ComponentModel.DataAnnotations.
            Display(Name = nameof(Resources.DataDictionary.LocalBookName))]
        [System.ComponentModel.DataAnnotations.
            Required(AllowEmptyStrings = false, ErrorMessage = nameof(Resources.ErrorMessages.NameRequiredError))]
        [System.ComponentModel.DataAnnotations.
            StringLength(maximumLength: 20, MinimumLength = 2, ErrorMessage = nameof(Resources.ErrorMessages.NameLengthError))]
        public string BookName { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.
            Column(name: nameof(Resources.DataDictionary.WriterName))]
        [System.ComponentModel.DataAnnotations.
            Display(Name = nameof(Resources.DataDictionary.LocalWriterName))]
        [System.ComponentModel.DataAnnotations.
            StringLength(maximumLength: 20, MinimumLength = 3, ErrorMessage = nameof(Resources.ErrorMessages.WriterNameLengthError))]
        public string WriterName { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.
            Column(name: nameof(Resources.DataDictionary.PublishYear))]
        [System.ComponentModel.DataAnnotations.
            Display(Name = nameof(Resources.DataDictionary.LocalPublishYear))]
        [System.ComponentModel.DataAnnotations.
            Range(minimum: 0, maximum: 10000, ErrorMessage = nameof(Resources.ErrorMessages.PublishYearRangeError))]
        public int PublishYear { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.
            Column(name: nameof(Resources.DataDictionary.Genre))]
        [System.ComponentModel.DataAnnotations.
            Display(Name = nameof(Resources.DataDictionary.LocalGenre))]
        [System.ComponentModel.DataAnnotations.
            Required(AllowEmptyStrings = false, ErrorMessage = nameof(Resources.ErrorMessages.GenreError))]
        public BookGenres Genre { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.
            Column(name: nameof(Resources.DataDictionary.BookType))]
        [System.ComponentModel.DataAnnotations.
            Display(Name =nameof(Resources.DataDictionary.LocalBookType))]
        [System.ComponentModel.DataAnnotations.
            Required(AllowEmptyStrings =false,ErrorMessage =nameof(Resources.ErrorMessages.BookTypeError))]
        public BookType BookType { get; set; }

        public string Description { get; set; }

        public virtual User OwnerUser { get; set; }

        public System.Guid OwnerUserId { get; set; }


    }
}
