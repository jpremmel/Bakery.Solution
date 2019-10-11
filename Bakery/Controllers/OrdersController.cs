using Microsoft.AspNetCore.Mvc;

namespace Bakery.Controllers
{
    public class OrdersController : Controller
    {
        [HttpGet("/orders")]
        public ActionResult Index()
        {
            return View();
        }
    }
}