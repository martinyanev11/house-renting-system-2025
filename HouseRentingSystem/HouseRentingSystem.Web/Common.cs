namespace HouseRentingSystem.Web
{
    using HouseRentingSystem.Web.Models.Houses;

    public class Common
    {
        public static IEnumerable<HouseDetailsViewModel> GetHouses()
        {
            var houses = new List<HouseDetailsViewModel>()
            {
                new HouseDetailsViewModel()
                {
                    Title = "House Maria",
                    Address = "Sofia, Bulgaria",
                    ImageUrl = "https://www.rocketmortgage.com/resources-cmsassets/RocketMortgage.com/Article_Images/Large_Images/TypesOfHomes/types-of-homes-hero.jpg"
                },
                new HouseDetailsViewModel()
                {
                    Title = "House Emil",
                    Address = "Burgas, Bulgaria",
                    // 404
                    ImageUrl = "https://media.istockphoto.com/id/147205632/photo/modern-home-with-swimming-pool.jpg?s=612x612&w=0&k=20&c=sxRQ398SxAjC4FrRombjl46oDGJVdy23T7i3RXO-mww="
                },
                new HouseDetailsViewModel()
                {
                    Title = "Family House",
                    Address = "Varna, Bulgaria",
                    ImageUrl = "https://media1.ispdd.com/projects/big/proekt-za-kashta-Varna-R5rH4-68627028273658452.jpg"
                }
            };

            return houses;
        }
    }
}
