using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dll.Model
{
    public class PickingOutItem
    {
        public int PickingOut_Id { get; set; }
        public int Literature_Id { get; set; }
        public PickingOut PickingOut { get; set; }
        public Literature Literature { get; set; }

    }
}
