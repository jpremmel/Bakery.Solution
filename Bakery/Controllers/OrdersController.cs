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
        public ActionResult Create(int vendorID, string title, string description, int price, string date)
        {
            Order order = new Order(title, description, price, date);
            Vendor.VendorList[vendorID-1].OrderList.Add(order);
            return RedirectToAction("Show", "Vendors");
        }
    }
}