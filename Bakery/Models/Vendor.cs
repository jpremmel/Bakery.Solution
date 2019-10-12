using System.Collections.Generic;

namespace Bakery.Models
{
    public class Vendor
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Order> OrderList = new List<Order> { };
        public static List<Vendor> VendorList = new List<Vendor> { };
        public int ID { get; }
        public static int idAssigner { get; set;}

        public Vendor(string name, string description)
        {
            Name = name;
            Description = description;
            idAssigner++;
            ID = idAssigner;
            VendorList.Add(this);
        }
    }
}