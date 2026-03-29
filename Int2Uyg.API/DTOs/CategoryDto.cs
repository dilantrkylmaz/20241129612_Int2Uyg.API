namespace Int2Uyg.API.DTOs
{
    public class CategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } 
        public bool IsActive { get; set; }
        public int SurveyCount { get; set; }
    }
}