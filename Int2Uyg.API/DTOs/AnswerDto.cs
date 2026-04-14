namespace Int2Uyg.API.DTOs
{
    public class AnswerDto
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int QuestionId { get; set; }
        public int SurveyId { get; set; }
        public string? TextAnswer { get; set; }
        public int? SelectedOptionId { get; set; }
    }
}