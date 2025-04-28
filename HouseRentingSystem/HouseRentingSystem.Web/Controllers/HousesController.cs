namespace HouseRentingSystem.Web.Controllers
{
    using HouseRentingSystem.Data;
    using HouseRentingSystem.Data.Models;
    using HouseRentingSystem.Web.Models.Houses;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Security.Claims;

    public class HousesController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public HousesController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult All()
        {
            AllHousesViewModel model = new AllHousesViewModel()
            {
                Houses = _dbContext.Houses
                    .Select(h => new HouseDetailsViewModel()
                    {
                        Title = h.Title,
                        Address = h.Address,
                        ImageUrl = h.ImageUrl,
                    })
            };

            return View(model);
        }

        public IActionResult Details(int id)
        {
            House? house = _dbContext.Houses.FirstOrDefault(h => h.Id == id);

            if (house is null)
            {
                return RedirectToAction("All");
            }

            HouseDetailsViewModel model = new HouseDetailsViewModel()
            {
                Title = house.Title,
                Address = house.Address,
                ImageUrl = house.ImageUrl,
            };

            return View(model);
        }

        [Authorize] 
        public IActionResult Mine()
        {
            var currentUserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            AllHousesViewModel model = new AllHousesViewModel()
            {
                Houses = _dbContext.Houses
                    .Where(h => h.Agent.UserId == currentUserId)
                    .Select(h => new HouseDetailsViewModel()
                    {
                        Title = h.Title,
                        Address = h.Address,
                        ImageUrl = h.ImageUrl,
                    })
            };

            return View(model);
        }
    }
}
