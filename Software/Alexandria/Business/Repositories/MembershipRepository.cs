using Data.Model;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;

namespace Business.Repositories
{
    public class MembershipRepository : GenericRepository<Membership>
    {
        private AppDbContext _dbContext { get; set; }

        public MembershipRepository(AppDbContext appDbContext) : base(appDbContext)
        {
            _dbContext = _appDbContext;
            _dbContext.Configuration.ProxyCreationEnabled = false;
            _dbContext.Configuration.LazyLoadingEnabled = false;
        }

        public List<Membership> GetAllMemberships()
        {
            return _dbContext.Memberships.Include(u => u.User).ToList();
        }
    }
}
