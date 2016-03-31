using System.Collections.Generic;

namespace PartialViewDemo.Models
{
    public class ViewModel
    {
        public List<Customer> Customers;
    }

    public class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
    }
}