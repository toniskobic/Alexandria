using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dll.Model
{
    public class Dismiss
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public List<DismissItem> DismissItem{ get; set; }
    }
}
