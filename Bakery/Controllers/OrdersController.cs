using Microsoft.AspNetCore.Mvc;
using Bakery.Models;

namespace Bakery.Controllers
{
    public class OrdersController : Controller
    {
        [HttpGet("/vendors/{ID}/orders/new")]
        public ActionResult New(int ID)
        {
            Vendor vendor = Vendor.VendorList[ID-1];
            return View(vendor);
        }

        [HttpPost("/vendors/{id}")]
        public ActionResult Create(string title, int vendorID)
        {
            Order order = new Order(title);
            Vendor.VendorList[vendorID-1].OrderList.Add(order);
            return RedirectToAction("Show", "Vendors");
        }


    }
}