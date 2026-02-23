namespace Int2Uyg.API.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Survey> Surveys { get; set; }
    }
}