using System.Collections.Generic;

namespace Data.Entities
{
    public class Role
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AuthorisationLevel { get; set; }
        public List<User> User { get; set; }

        public Role()
        {
        }
    }
}
