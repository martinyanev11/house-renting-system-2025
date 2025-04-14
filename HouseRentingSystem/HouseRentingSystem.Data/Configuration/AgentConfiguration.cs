namespace HouseRentingSystem.Data.Configuration
{
    using HouseRentingSystem.Data.Models;
    using HouseRentingSystem.Data.Seeding;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class AgentConfiguration : IEntityTypeConfiguration<Agent>
    {
        public void Configure(EntityTypeBuilder<Agent> builder)
        {
            builder.HasData(AgentSeeder.SeedAgents());
        }
    }
}
