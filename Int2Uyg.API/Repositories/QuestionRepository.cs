using Int2Uyg.API.Models;

namespace Int2Uyg.API.Repositories
{
    public class QuestionRepository : GenericRepository<Question>
    {
        public QuestionRepository(AppDbContext context) : base(context)
        {
        }
    }
}