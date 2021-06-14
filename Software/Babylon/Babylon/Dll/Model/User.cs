using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dll.Model
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string PhoneNumber { get; set; }
        public bool Locked { get; set; }
        public Role Role { get; set; }
        public List<Membership> Membership { get; set; }
        public List<Receipt> UserReceipt { get; set; }
        public List<Receipt> EmployeeReceipt { get; set; }
        public List<Loan> Loan { get; set; }





    }
}
