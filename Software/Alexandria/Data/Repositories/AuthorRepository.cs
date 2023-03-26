using Data.Entities;

namespace Data.Repositories
{
    public class AuthorRepository : GenericRepository<Author>
    {
        public AuthorRepository(AlexandriaContext appDbContext) : base(appDbContext)
        {
        }
    }
}
