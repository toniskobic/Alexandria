using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dll.Model
{
    public class ReceiptItem
    {
        public int Receipt_Id { get; set; }
        public int Loan_Id { get; set; }
        public Loan Loan{ get; set; }
        public Receipt Receipt { get; set; }

        public double Money{ get; set; }
    }
}
