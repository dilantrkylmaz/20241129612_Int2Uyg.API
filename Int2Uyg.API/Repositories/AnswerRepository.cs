using Int2Uyg.API.Models;

namespace Int2Uyg.API.Repositories
{
    public class AnswerRepository : GenericRepository<Answer>
    {
        public AnswerRepository(AppDbContext context) : base(context)
        {
        }
    }
}