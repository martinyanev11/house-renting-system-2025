namespace HouseRentingSystem.Data.Seeding
{
    using HouseRentingSystem.Data.Models;
    using static HouseRentingSystem.Data.Seeding.Constants.Constants;

    public class HouseSeeder
    {
        public static IEnumerable<House> SeedHouses()
        {
            IEnumerable<House> houses = new List<House>()
            {
                new House(HouseConstants.BigHouesMarinaId, HouseConstants.BigHouseMarinaName, HouseConstants.BigHouseMarinaAddress, HouseConstants.BigHouseMarinaDescription, HouseConstants.BigHouseMarinaImageUrl, HouseConstants.BigHouseMarinaPricePerMonth)
                {
                    CategoryId = CategoryConstants.DuplexId,
                    AgentId = Guid.Parse(AgentConstants.Id),
                    RenterId = UserConstants.GuestId,
                },
                new House(HouseConstants.FamilyHouseComfortId, HouseConstants.FamilyHouseComfortTitle, HouseConstants.FamilyHouseComfortAddress, HouseConstants.FamilyHouseComfortDescription, HouseConstants.FamilyHouseComfortImageUrl, HouseConstants.FamilyHouseComfortPricePerMonth)
                {
                    CategoryId = CategoryConstants.SingleFamilyId,
                    AgentId = Guid.Parse(AgentConstants.Id),
                },
                new House(HouseConstants.GrandHouseId, HouseConstants.GrandHouseTitle, HouseConstants.GrandHouseAddress, HouseConstants.GrandHouseDescription, HouseConstants.GrandHouseImageUrl, HouseConstants.GrandHousePricePerMonth)
                {
                    CategoryId = CategoryConstants.SingleFamilyId,
                    AgentId = Guid.Parse(AgentConstants.Id),
                }
            };

            return houses;
        }
    }
}
