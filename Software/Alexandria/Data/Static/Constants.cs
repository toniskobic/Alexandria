using System.Collections.Generic;

namespace Data.Static
{
    public static class Constants
    {
        public const string ROLE_ADMIN = "Admin";
        public const string ROLE_USER = "User";
        public const string ROLE_MEMBER = "Member";

        private static readonly IList<string> ALL_ROLES = new List<string>()
        {
            ROLE_ADMIN,
            ROLE_USER,
            ROLE_MEMBER
        };

        public static IList<string> GetAllRoles()
        {
            return new List<string>(ALL_ROLES);
        }
    }
}
