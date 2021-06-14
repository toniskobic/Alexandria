using Dll.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bll.Repositories
{
    public class LiteratureRepository : GenericRepository<Literature>
    {
        public LiteratureRepository(AppDbContext dbContext) : base(dbContext)
        {

        }
        public bool IsLoaned(int id)
        {
            var loanItems = _appDbContext.Literatures.Include("LoanItem").FirstOrDefault(l => l.Id == id).LoanItem;
            bool isLoaned = false;
            foreach (var loanItem in loanItems)
            {
                var newLoanItem = _appDbContext.LoanItems.Include("Loan").FirstOrDefault(li => li.Id == loanItem.Id);
                if (loanItem.Loan.DateTo >= DateTime.Now)
                {
                    isLoaned = true;
                    break;
                }
            }

            return isLoaned;
        }
        
    }
}
