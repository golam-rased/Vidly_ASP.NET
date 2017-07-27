using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using vidly.Models;

namespace vidly.ViewModel
{
    public class CustomerViewModel
    {
        public List<Customer> Customers { get; set; }
        public Customer Customer { get; set; }
    }
}