namespace Models
{
    public abstract class BaseEntity : object
    {
        public BaseEntity()
        {
            Id = System.Guid.NewGuid();
        }
        [System.ComponentModel.DataAnnotations.Key]
        public System.Guid Id { get; set; }

    }
}
