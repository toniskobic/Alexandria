using System;
using System.Collections.Generic;

namespace Data.Entities
{
    public class PickingIn
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public List<PickingInItem> PickingInItem { get; set; }

        public PickingIn()
        {
            Date = DateTime.Now;
            PickingInItem = new List<PickingInItem>();
        }
    }
}
