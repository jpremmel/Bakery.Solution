using Microsoft.AspNetCore.Mvc;
using Bakery.Models;

namespace Bakery.Controllers
{
    public class VendorsController : Controller
    {
        [HttpGet("/vendors")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet("/vendors/new")]
        public ActionResult New(string name)
        {
            return View();
        }

        [HttpPost("/vendors")]
        public ActionResult Create(string name)
        {
            Vendor vendor = new Vendor(name);
            return RedirectToAction("Index");
        }

        [HttpGet("/vendors/{ID}/orders")]
        public ActionResult Show(int ID)
        {
            Vendor vendor = Vendor.VendorList[ID-1];
            return View(vendor);
        }

        


    }
}