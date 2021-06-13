using Dll.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Repositories
{
    public class UserRepository : GenericRepository<User>
    {
        public UserRepository(AppDbContext dbContext) : base(dbContext)
        {

        }
    }
}
