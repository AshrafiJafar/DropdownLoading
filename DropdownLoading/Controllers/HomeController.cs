using DropdownLoading.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DropdownLoading.Controllers
{
    public class HomeController : Controller
    {
        

        public IActionResult Index()
        {
            var provinces = Data.Provinces.ToList();
            return View(provinces);
        }

        public IActionResult GetCities(int id)
        {
            var province = Data.Provinces.Single(x => x.Id == id);
            return PartialView("_CitiesOptions", province.Cities);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}