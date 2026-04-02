namespace Int2Uyg.API.DTOs
{
    public class AnswerDto
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int QuestionId { get; set; }
        public string ResponseText { get; set; }
    }
}