using Dll.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Repositories
{
    public class LoanRepository : GenericRepository<Loan>
    {
        public LoanRepository(AppDbContext dbContext) : base(dbContext)
        {

        }
    }
}
