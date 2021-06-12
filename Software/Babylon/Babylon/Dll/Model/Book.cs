using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dll.Model
{
    public class Book
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public Category Category { get; set; }
        public Author Author{ get; set; }
        public List<ArrivalItem> ArrivalItem { get; set; }
        public List<DismissItem> DismissItem{ get; set; }
        public List<LoanItem> LoanItem{ get; set; }
    }
}
