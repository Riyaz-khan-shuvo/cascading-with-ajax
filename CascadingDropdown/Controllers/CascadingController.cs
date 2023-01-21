using CascadingDropdown.Data;
using Microsoft.AspNetCore.Mvc;

namespace CascadingDropdown.Controllers
{
    public class CascadingController : Controller
    {
        private readonly CascadingDbContext _context;

        public CascadingController(CascadingDbContext context)
        {
            _context = context;
        }
        public JsonResult Country()
        {
            var ctn = _context.Countries.ToList();
            return new JsonResult(ctn);
        }

        public JsonResult State(int id)
        {
            var st = _context.States.Where(s => s.Country.Id == id).ToList();
            return new JsonResult(st);
        }
        public JsonResult City(int id)
        {
            var city = _context.Cities.Where(s => s.State.Id == id).ToList();
            return new JsonResult(city);
        }

        public IActionResult CascadDropdown()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }

}

