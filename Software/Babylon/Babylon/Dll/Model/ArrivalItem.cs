using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dll.Model
{
    public class ArrivalItem
    {
        public int ArrivalID { get; set; }
        public Arrival Arrival{ get; set; }

        public int BookID { get; set; }
        public Book Book{ get; set; }
    }
}
