using System.Collections.Generic;

namespace Bakery.Models
{
    public class Vendor
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public static List<Order> OrderList = new List<Order> { };
        public int ID { get; }
        public static int idAssigner { get; set;}

        
    }
}