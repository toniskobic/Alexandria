using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dll.Model
{
    public class PickingOut
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public List<PickingOutItem> PickingOutItem { get; set; }

        public PickingOut()
        {
            Date = DateTime.Now;
        }
    }
}
