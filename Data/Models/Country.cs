namespace Lucky.WebAPI.Data.Models
{
    public class Country
    {
        public Country()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
