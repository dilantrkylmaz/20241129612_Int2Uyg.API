namespace Int2Uyg.API.DTOs
{
    public class SurveyDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PhotoUrl { get; set; }
        public int CategoryId { get; set; }
        public string UserId { get; set; }
        public bool IsActive { get; set; }
    }
}