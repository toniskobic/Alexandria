using System.Collections.Generic;

namespace Data.Entities
{
    public class Category
    {
        public int Id { get; set; }

        public string Name{ get; set; }

        public string Description { get; set; }

        public List<Literature> Literature { get; set; }

        public Category()
        {

        }
        public Category(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
