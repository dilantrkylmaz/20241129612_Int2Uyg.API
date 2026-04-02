namespace Int2Uyg.API.Models
{
    public class QuestionOption : BaseEntity
    {
        public int QuestionId { get; set; }
        public Question Question { get; set; }

       public string OptionText { get; set; }
    }
}