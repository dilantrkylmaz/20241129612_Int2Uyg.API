namespace Int2Uyg.API.Models
{
    public class Survey : BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; } 
        public string PhotoUrl { get; set; } 
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        public string UserId { get; set; }
        public AppUser? User { get; set; }

        public ICollection<Question>? Questions { get; set; }
    }
}