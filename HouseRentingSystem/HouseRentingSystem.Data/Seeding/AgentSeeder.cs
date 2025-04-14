namespace HouseRentingSystem.Data.Seeding
{
    using HouseRentingSystem.Data.Models;

    public class AgentSeeder
    {
        public static IEnumerable<Agent> SeedAgents()
        {
            List<Agent> agents = new List<Agent>()
            {
                new Agent()
                {
                    Id = Guid.Parse("44a41a1c-943b-47e2-80e6-47463b6f139b"),
                    PhoneNumber = "+359888888888",
                    UserId = "dea12856-c198-4129-b3f3-b893d8395082"
                }
            };

            return agents;
        }
    }
}
