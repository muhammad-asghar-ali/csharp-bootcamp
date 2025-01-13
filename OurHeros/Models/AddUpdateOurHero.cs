namespace OurHeros.Models
{
    public class AddUpdateOurHero
    {
        public required string FirstName { get; set; }
        public string LastName { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
    }
}