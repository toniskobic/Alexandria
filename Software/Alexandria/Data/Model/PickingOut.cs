using System;

namespace Data.Model
{
    public class PickingOut
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }

        public PickingOut()
        {
            Date = DateTime.Now;
        }
    }
}
