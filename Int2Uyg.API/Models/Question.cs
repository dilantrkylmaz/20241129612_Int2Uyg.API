namespace Int2Uyg.API.Models
{
    public class Question : BaseEntity
    {
        public string Text { get; set; } 

        public int SurveyId { get; set; }
        public Survey? Survey { get; set; }
    }
}