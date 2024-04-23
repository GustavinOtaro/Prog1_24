using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula04_01.Models;
using Aula04_01.Data;

namespace Aula04_01.Data
{
    public class DataSet
    {
        public static List<Address> Addresses { get; set; }
        public static List<Customer> Customers { get; set; }
        public static List<Order> Orders { get; set; }
        public static List<OrderItem> OrderItems { get; set; }
        public static List<Product> Products { get; set; }
    }
}