using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dll.Model
{
    public class Category
    {
        public int ID { get; set; }
        public string Name{ get; set; }
        public string Description { get; set; }
        public List<Book> Book { get; set; }
    }
}
