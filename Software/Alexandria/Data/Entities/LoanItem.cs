using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities
{
    public class LoanItem
    {
        public int Id { get; set; }

        public int LoanId { get; set; }

        public Loan Loan { get; set; }

        public int LiteratureId { get; set; }

        public Literature Literature { get; set; }

        [NotMapped]
        public string LiteratureTitle
        {
            get
            {
                return Literature.Title;
            }
        }

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
