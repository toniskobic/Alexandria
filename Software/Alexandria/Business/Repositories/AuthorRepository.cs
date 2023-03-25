using Data.Model;

namespace Business.Repositories
{
    public class AuthorRepository : GenericRepository<Author>
    {
        public AuthorRepository(AppDbContext dbContext) : base(dbContext)
        {

        }
    }
}
