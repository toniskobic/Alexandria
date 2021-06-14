using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dll.Model
{
    public class Literature
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Category Category { get; set; }
        public Author Author{ get; set; }
        public List<LoanItem> LoanItem { get; set; }
        public List<PickingInItem> PickingInItem { get; set; }
        public List<PickingOutItem> PickingOutItem { get; set; }

        public Literature()
        {

        }
        public Literature(string title, Category category, Author author)
        {
            Title = title;
            Category = category;
            Author = author;
        }
    }
}
