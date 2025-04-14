namespace HouseRentingSystem.Data.Seeding
{
    using Microsoft.AspNetCore.Identity;

    public class UserSeeder
    {
        public static IEnumerable<IdentityUser> SeedUsers()
        {
            string defaultPassword = "user123";

            List<IdentityUser> users = new List<IdentityUser>()
            {
                new IdentityUser()
                {
                    Id = "dea12856-c198-4129-b3f3-b893d8395082",
                    UserName = "agent@mail.com",
                    NormalizedUserName = "agent@mail.com",
                    Email = "agent@mail.com",
                    NormalizedEmail = "agent@mail.com"
                },
                new IdentityUser()
                {
                    Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                    UserName = "guest@mail.com",
                    NormalizedUserName = "guest@mail.com",
                    Email = "guest@mail.com",
                    NormalizedEmail = "guest@mail.com"
                }
            };

            var hasher = new PasswordHasher<IdentityUser>();

            foreach (var user in users)
            {
                user.PasswordHash = hasher.HashPassword(user, defaultPassword);
            }

            return users;
        }

    }
}
