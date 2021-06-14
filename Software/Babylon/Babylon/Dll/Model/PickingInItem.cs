using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dll.Model
{
    public class PickingInItem
    {
        public int PickingIn_Id { get; set; }
        public int Literature_Id { get; set; }
        public PickingIn PickingIn { get; set; }
        public Literature Literature { get; set; }
        public PickingInItem()
        {
        }
    }
}
