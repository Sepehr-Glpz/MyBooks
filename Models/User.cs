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
        }
        public string UserName { get; set; }

        public string Password { get; set; }
        [System.ComponentModel.Browsable(false)]
        public ComplexTypes.FullName FullName { get; set; }

        public virtual System.Collections.Generic.IList<Book> Books { get; set; }

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


    }
}
