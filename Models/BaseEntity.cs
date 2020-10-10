namespace Models
{
    public abstract class BaseEntity : object
    {
        public BaseEntity() : base()
        {
            Id = System.Guid.NewGuid();
        }
        [System.ComponentModel.Browsable(false)]
        [System.ComponentModel.DataAnnotations.Key]
        public System.Guid Id { get; set; }

    }
}
