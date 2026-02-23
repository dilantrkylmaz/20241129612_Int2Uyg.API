namespace Int2Uyg.API.Models
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public bool IsActive { get; set; } = true; 
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime? UpdatedDate { get; set; } 
    }
}