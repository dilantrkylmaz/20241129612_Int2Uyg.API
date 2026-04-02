using Int2Uyg.API.Models;

namespace Int2Uyg.API.Repositories
{
    public class QuestionOptionRepository : GenericRepository<QuestionOption>
    {
        public QuestionOptionRepository(AppDbContext context) : base(context)
        {
        }
    }
}