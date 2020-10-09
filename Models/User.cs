namespace Models
{
    public class User : BaseEntity
    {
        #region Configuration
        internal class Configuration :
            System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<User>
        {
            public Configuration() : base()
            {

            }
        }
        #endregion /Configuration

        public User() : base()
        {
            FullName = new ComplexTypes.FullName();
            IsSysAdmin = false;
        }
        public string Username { get; set; }

        public string Password { get; set; }

        public string Description { get; set; }

        [System.ComponentModel.Browsable(false)]
        public ComplexTypes.FullName FullName { get; set; }

        public virtual System.Collections.Generic.IList<Book> Books { get; set; }

        public bool IsSysAdmin { get; set; }

        public bool IsAdmin { get; set; }

        public bool IsActive { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        public string DisplayFullName
        {
            get
            {
                string result = FullName.ToString();
                if (string.IsNullOrEmpty(result)==true)
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
                if(IsActive==true)
                {
                    result = $"{result}- [ENABLED]";
                }
                else
                {
                    result = $"{result}- [DISABLED]";
                }
                if (IsAdmin==true)
                {
                    result = $"{result}- [ADMIN]";
                }
                else
                {
                    result = $"{result}- [USER]";
                }
                if (IsSysAdmin==true)
                {
                    result = $"{result}- [SYSTEM ADMIN]";
                }
                return result;
            }
        }

    }
}
