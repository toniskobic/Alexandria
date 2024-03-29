﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities
{
    public class User
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        public string EMail { get; set; }

        [MaxLength(255)]
        public string PasswordHash { get; set; }

        [MaxLength(255)]
        public string PasswordSalt { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime RegistrationDate { get; set; }

        public string PhoneNumber { get; set; }

        public bool Locked { get; set; }

        public Role Role { get; set; }

        public List<Membership> Membership { get; set; }

        public List<Receipt> UserReceipt { get; set; }

        public List<Receipt> EmployeeReceipt { get; set; }

        public List<Loan> Loan { get; set; }

        [NotMapped]
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        [NotMapped]
        public string RoleName
        {
            get
            {
                return Role.Name;
            }
        }

        public User()
        {
            RegistrationDate = DateTime.Now;
            Loan = new List<Loan>();
        }
    }
}
