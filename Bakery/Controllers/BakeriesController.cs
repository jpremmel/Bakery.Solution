using Microsoft.AspNetCore.Mvc;
using Bakery.Models;

namespace Bakery.Controllers
{
    public class BakeriesController : Controller
    {
        [HttpGet("/vendors")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost("/vendors/new")]
        public ActionResult New(string name)
        {
            Vendor vendor = new Vendor(name);
            return View();
        }


    }
}