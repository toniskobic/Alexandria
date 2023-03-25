using Data.Model;

namespace Business.Repositories
{
    public class CategoryRepository : GenericRepository<Category>
    {
        public CategoryRepository(AppDbContext dbContext) : base(dbContext)
        {

        }
    }
}
