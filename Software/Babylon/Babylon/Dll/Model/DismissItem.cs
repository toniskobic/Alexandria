using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dll.Model
{
    public class DismissItem
    {
        public int DismissId { get; set; }
        public Dismiss Dismiss{ get; set; }

        public int BookID { get; set; }
        public Book Book { get; set; }
    }
}
