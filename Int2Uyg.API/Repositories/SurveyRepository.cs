using Int2Uyg.API.Models;
using Microsoft.EntityFrameworkCore;

namespace Int2Uyg.API.Repositories
{
    public class SurveyRepository : GenericRepository<Survey>
    {
        public SurveyRepository(AppDbContext context) : base(context)
        {
        }

        public override async Task<List<Survey>> GetAllAsync()
        {
            return await _context.Surveys
                .Include(s => s.Category) 
                .Where(s => !s.IsDeleted)
                .ToListAsync();
        }
    }
}