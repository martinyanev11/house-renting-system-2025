using System.Diagnostics;
using HouseRentingSystem.Data;
using HouseRentingSystem.Web.Models;
using HouseRentingSystem.Web.Models.Home;
using Microsoft.AspNetCore.Mvc;

namespace HouseRentingSystem.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _dbContext;

        public HomeController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            IndexViewModel model = new IndexViewModel()
            {
                TotalHouses = _dbContext.Houses.Count(),
                TotalRents = _dbContext.Houses.Where(h => h.RenterId != null).Count(),
                Houses = _dbContext.Houses
                    .Select(h => new HouseIndexViewModel()
                    {
                        Title = h.Title,
                        ImageUrl = h.ImageUrl,
                    }).ToList()
            };
            
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
