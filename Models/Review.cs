namespace LearnWebAPI.Models
{
    public class Review
    {

        public int Id { get; set; }
        public int ProductId {  get; set; }

        public Product Product { get; set; }

        public int UserId { get; set; }
        public User AppUser { get; set; }
        public string Content { get; set; } = string.Empty;
        public DateOnly CreationDate { get; set; } = DateOnly.FromDateTime(DateTime.Now);

    }
}
