namespace HouseRentingSystem.Data.Configuration
{
    using HouseRentingSystem.Data.Models;
    using HouseRentingSystem.Data.Seeding;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(CategorySeeder.SeedCategories());
        }
    }
}
