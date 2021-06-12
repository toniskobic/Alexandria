using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dll.Model
{
    public class Loan
    {
        public int ID { get; set; }
        public User UserID { get; set; }
        public bool Started { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public List<LoanItem> LoanItem { get; set; }
        public List<ReceiptItem> ReceiptItem { get; set; }
    }
}
