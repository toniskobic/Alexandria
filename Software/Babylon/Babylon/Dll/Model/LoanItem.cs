using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dll.Model
{
    public class LoanItem
    {
        public int Id { get; set; }
        public int LoanId { get; set; }
        public Loan Loan { get; set; }
        public int LiteratureId { get; set; }
        public Literature Literature { get; set; }
        public LoanItem()
        {

        }
        public LoanItem(Loan loan, Literature literature)
        {
            Loan = loan;
            Literature = literature;
        }
    }
}
