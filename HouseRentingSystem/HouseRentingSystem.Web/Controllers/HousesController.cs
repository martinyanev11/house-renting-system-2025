namespace HouseRentingSystem.Web.Controllers
{
    using HouseRentingSystem.Web.Models.Houses;
    using Microsoft.AspNetCore.Mvc;

    public class HousesController : Controller
    {
        public IActionResult All()
        {
            AllHousesViewModel model = new AllHousesViewModel()
            {
                Houses = Common.GetHouses()
            };

            return View(model);
        }

        public IActionResult Details()
        {
            HouseDetailsViewModel model = Common.GetHouses().First();
            return View(model);
        }
    }
}
