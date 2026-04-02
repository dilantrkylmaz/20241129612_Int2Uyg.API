namespace Int2Uyg.API.Models
{
    public class Answer : BaseEntity
    {

        public string UserId { get; set; }
        public AppUser User { get; set; }

        public int QuestionId { get; set; }
        public Question Question { get; set; }

        public string ResponseText { get; set; }
    }
}