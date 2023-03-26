using Data.Interfaces;
using System.Threading.Tasks;

namespace Data
{
    public class DatabaseScope : IDatabaseScope
    {
        private readonly AppDbContext _appDbContext;

        public DatabaseScope(AppDbContext ekoshipContext)
        {
            _appDbContext = ekoshipContext;
        }

        public Task<int> SaveAsync()
        {
            return _appDbContext.SaveChangesAsync();
        }
    }
}
