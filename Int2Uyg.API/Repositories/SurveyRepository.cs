using Int2Uyg.API.Models;

namespace Int2Uyg.API.Repositories
{
    public class SurveyRepository : GenericRepository<Survey>
    {
        public SurveyRepository(AppDbContext context) : base(context)
        {
        }
    }
}