using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula04_01.Models;
using Aula04_01.Data;

namespace Aula04_01.Repository
{
    public class OrderRepository
    {
        public void Save (Order customer)
        {
            DataSet.Orders.Add (customer);
        }

        public Order Retrieve(int id)
        {
            foreach (var c in DataSet.Orders) 
            {
                if( c.OrderId == id )
                {
                    return c;
                }

            }

            return null;
        }
    }
}
    
