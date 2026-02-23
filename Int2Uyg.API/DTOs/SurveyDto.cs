namespace Int2Uyg.API.DTOs
{
    public class SurveyDto : BaseDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
    }
}