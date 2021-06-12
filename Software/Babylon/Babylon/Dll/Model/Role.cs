using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dll.Model
{
    public class Role
    {
        public int ID { get; set; }
        public string RoleName { get; set; }
        public int AuthorisationLevel { get; set; }
        public List<User> User { get; set; }
    }
}
