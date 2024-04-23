using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula04_01.Models;
using Aula04_01.Data;

namespace Aula04_01.Repository
{
    public class OrdemItemRepository
    {
        public void Save (OrderItem customer)
        {
            DataSet.OrderItems.Add (customer);
        }

        public OrderItem Retrieve(int id)
        {
            foreach (var c in DataSet.OrderItems) 
            {
                if( c.OrderItemId == id )
                {
                    return c;
                }

            }

            return null;
        }
    }
}
    
