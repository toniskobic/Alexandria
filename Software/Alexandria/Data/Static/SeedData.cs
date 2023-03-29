using System;
using Data.Entities;

namespace Data.Static
{
    public static class SeedData
    {
        public static readonly string[] Categories = new string[]
        {
            "Fiction",
            "Science Fiction",
            "Comic",
            "Science"
        };

        public static SeedUser[] Users()
        {
            return new SeedUser[]
            {
                new SeedUser
                {
                    FirstName = "Admin",
                    LastName = "Admin",
                    UserName = "admin",
                    EMail = "admin@alexandria.library.com",
                    Password = "user123",
                    DateOfBirth = new DateTime(1995, 9, 4),
                    PhoneNumber = "1234567890",
                    Locked = false,
                    Role = Constants.ROLE_ADMIN
                },
                new SeedUser
                {
                    FirstName = "Member",
                    LastName = "Member",
                    UserName = "member",
                    EMail = "member@alexandria.library.com",
                    Password = "user123",
                    DateOfBirth = new DateTime(1992, 4, 3),
                    PhoneNumber = "0987654321",
                    Locked = false,
                    Role = Constants.ROLE_MEMBER
                }
            };
        }

        public static Author[] Authors()
        {
            return new Author[]
            {
                new Author
                {
                    FirstName = "Jordan",
                    LastName = "Peterson",

                },
                new Author
                {
                    FirstName = "Ivo",
                    LastName = "Andrić",

                },
                new Author
                {
                    FirstName = "Dobriša",
                    LastName = "Cesarić",

                },
                new Author
                {
                    FirstName = "Fyodor",
                    LastName = "Dostoevsky",
                }
            };
        }
    }
}
