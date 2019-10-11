using Microsoft.AspNetCore.Mvc;
using Bakery.Models;

namespace Bakery.Controllers
{
    public class BakeriesController : Controller
    {
        [HttpGet("/bakeries")]
        public ActionResult Index()
        {
            return View();
        }
    }
}