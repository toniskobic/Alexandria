using System.Threading.Tasks;
using Data.Interfaces;

namespace Data
{
    public class DatabaseScope : IDatabaseScope
    {
        private readonly AlexandriaContext _appDbContext;

        public DatabaseScope(AlexandriaContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Task<int> SaveAsync()
        {
            return _appDbContext.SaveChangesAsync();
        }
    }
}
