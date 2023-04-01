using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities
{
    public class PickingInItem
    {
        public int PickingIn_Id { get; set; }

        public int Literature_Id { get; set; }

        public PickingIn PickingIn { get; set; }

        public Literature Literature { get; set; }

        [NotMapped]
        public string LiteratureTitle
        {
            get
            {
                return Literature?.Title;
            }
        }

        public PickingInItem()
        {
        }
    }
}
