using Data.Static;
using Data.Entities;
using System.Data.Entity.Migrations;
using System;
using System.Linq;

namespace Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<AlexandriaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(AlexandriaContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            var roles = Constants.GetAllRoles();
            foreach (var role in roles)
            {
                context.Roles.AddOrUpdate(r => r.Name,
                new Role
                {
                    Name = role
                });
            }
            context.SaveChanges();

            var categories = SeedData.Categories;
            foreach (var category in categories)
            {
                context.Categories.AddOrUpdate(c => c.Name,
                new Category
                {
                    Name = category,
                    Description = category
                });
            }
            context.SaveChanges();

            var users = SeedData.Users();
            foreach (var user in users)
            {
                var salt = SeedUtils.CreateSalt();
                var hash = SeedUtils.HashPasword(user.Password, salt);

                context.Users.AddOrUpdate(u => u.UserName,
                new User
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    UserName = user.UserName,
                    EMail = user.EMail,
                    PasswordHash = hash,
                    PasswordSalt = salt,
                    DateOfBirth = user.DateOfBirth,
                    RegistrationDate = DateTime.Now,
                    PhoneNumber = user.PhoneNumber,
                    Locked = user.Locked,
                    Role = context.Roles.Where(r => r.Name == user.Role).FirstOrDefault()
                });
            }
            context.SaveChanges();

            var authors = SeedData.Authors();
            foreach (var author in authors)
            {
                context.Authors.AddOrUpdate(a => new { a.FirstName, a.LastName },
                    new Author
                    {
                        FirstName = author.FirstName,
                        LastName = author.LastName,
                    });
            }
            context.SaveChanges();
        }
    }
}
