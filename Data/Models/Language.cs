namespace Lucky.WebAPI.Data.Models
{
    public class Language
    {
        public Language()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
