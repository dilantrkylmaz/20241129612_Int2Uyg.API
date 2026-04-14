namespace Int2Uyg.API.Models
{
    public class Answer : BaseEntity
    {
        public string? TextAnswer { get; set; }
        public int? SelectedOptionId { get; set; }
        public QuestionOption? SelectedOption { get; set; }

        public string UserId { get; set; }
        public AppUser User { get; set; }

        public int QuestionId { get; set; }
        public Question Question { get; set; }

        public int SurveyId { get; set; }
        public Survey Survey { get; set; }
    }
}