using Data.Entities;

namespace Data.Repositories
{
    public class CategoryRepository : GenericRepository<Category>
    {
        public CategoryRepository(AlexandriaContext appDbContext) : base(appDbContext)
        {
        }
    }
}
