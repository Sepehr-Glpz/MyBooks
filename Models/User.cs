namespace Models
{
    [System.ComponentModel.DataAnnotations.Schema.
        Table(name: "Users")]
    public class User : BaseEntity
    {
        #region Configuration
        internal class Configuration :
            System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<User>
        {
            public Configuration() : base()
            {
                Property(current => current.Username)
                    .HasMaxLength(20)
                    .IsVariableLength()
                    .IsUnicode();

                Property(current => current.Password)
                    .HasMaxLength(25)
                    .IsVariableLength()
                    .IsUnicode();

                Property(current => current.Description)
                    .HasMaxLength(1024)
                    .IsVariableLength()
                    .IsUnicode()
                    .IsOptional();

            }
        }
        #endregion /Configuration

        public User() : base()
        {
            FullName = new ComplexTypes.FullName();
            IsSysAdmin = false;
        }

        [System.ComponentModel.DataAnnotations.Schema.
            Column(name: "Username")]
        [System.ComponentModel.DataAnnotations.
            Display(ResourceType = typeof(Resources.DataDictionary),
            Name = nameof(Resources.DataDictionary.LocalUsername))]
        [System.ComponentModel.DataAnnotations.
            Required(AllowEmptyStrings = false,
            ErrorMessageResourceType = typeof(Resources.ErrorMessages),
            ErrorMessageResourceName = nameof(Resources.ErrorMessages.UsernameRequiredError))]
        [System.ComponentModel.DataAnnotations.
            StringLength(maximumLength: 20, MinimumLength = 3,
            ErrorMessageResourceType = typeof(Resources.ErrorMessages),
            ErrorMessageResourceName = nameof(Resources.ErrorMessages.UsernameLengthError))]
        public string Username { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.
            Column(name: "User Password")]
        [System.ComponentModel.DataAnnotations.
            Display(ResourceType = typeof(Resources.DataDictionary),
            Name = nameof(Resources.DataDictionary.LocalPasswordName))]
        [System.ComponentModel.DataAnnotations.
            Required(AllowEmptyStrings = false,
            ErrorMessageResourceType = typeof(Resources.ErrorMessages),
            ErrorMessageResourceName = nameof(Resources.ErrorMessages.PasswordRequiredError))]
        [System.ComponentModel.DataAnnotations.
            StringLength(maximumLength: 25, MinimumLength = 5,
            ErrorMessageResourceType = typeof(Resources.ErrorMessages),
            ErrorMessageResourceName = nameof(Resources.ErrorMessages.PasswordLengthError))]
        public string Password { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.
            Column(name: "Description")]
        [System.ComponentModel.DataAnnotations.
            Display(ResourceType = typeof(Resources.DataDictionary),
            Name = nameof(Resources.DataDictionary.LocalUserDescription))]
        [System.ComponentModel.DataAnnotations.
            StringLength(maximumLength: 1024, MinimumLength = 0,
            ErrorMessageResourceType = typeof(Resources.ErrorMessages),
            ErrorMessageResourceName = nameof(Resources.ErrorMessages.UserDescriptionLengthError))]
        public string Description { get; set; }

        [System.ComponentModel.Browsable(false)]
        public ComplexTypes.FullName FullName { get; set; }

        public virtual System.Collections.Generic.IList<Book> Books { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.
            Column(name: "System Admin")]
        [System.ComponentModel.DataAnnotations.
            Display(ResourceType = typeof(Resources.DataDictionary),
            Name = nameof(Resources.DataDictionary.LocalIsSysAdmin))]
        [System.ComponentModel.DataAnnotations.
            Required(ErrorMessageResourceType = typeof(Resources.ErrorMessages),
            ErrorMessageResourceName = nameof(Resources.ErrorMessages.IsSysAdminError))]
        public bool IsSysAdmin { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.
            Column(name: "Admin")]
        [System.ComponentModel.DataAnnotations.
            Display(ResourceType = typeof(Resources.DataDictionary),
            Name = nameof(Resources.DataDictionary.LocalIsAdmin))]
        [System.ComponentModel.DataAnnotations.
            Required(ErrorMessageResourceType = typeof(Resources.ErrorMessages),
            ErrorMessageResourceName = nameof(Resources.ErrorMessages.IsAdminError))]
        public bool IsAdmin { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.
            Column(name: "Active")]
        [System.ComponentModel.DataAnnotations.
            Display(ResourceType = typeof(Resources.DataDictionary),
            Name = nameof(Resources.DataDictionary.LocalIsActive))]
        [System.ComponentModel.DataAnnotations.
            Required(ErrorMessageResourceType = typeof(Resources.ErrorMessages),
            ErrorMessageResourceName = nameof(Resources.ErrorMessages.IsActiveError))]
        public bool IsActive { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        [System.ComponentModel.DataAnnotations.
            Display(ResourceType = typeof(Resources.DataDictionary),
            Name = nameof(Resources.DataDictionary.DisplayFullName))]
        public string DisplayFullName
        {
            get
            {
                string result = FullName.ToString();
                if (string.IsNullOrEmpty(result) == true)
                {
                    result = "Undefined";
                }
                return result;
            }

        }
        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        public string DisplayListName
        {
            get
            {
                string result = $"Username: {Username}";
                if (DisplayFullName != "Undefined")
                {
                    result = $"{result}- Fullname: {DisplayFullName}";
                }
                if (IsActive == true)
                {
                    result = $"{result}- [ENABLED]";
                }
                else
                {
                    result = $"{result}- [DISABLED]";
                }
                if (IsAdmin == true)
                {
                    result = $"{result}- [ADMIN]";
                }
                else
                {
                    result = $"{result}- [USER]";
                }
                if (IsSysAdmin == true)
                {
                    result = $"{result}- [SYSTEM ADMIN]";
                }
                return result;
            }
        }

    }
}
