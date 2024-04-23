using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula04_01.Models;
using Aula04_01.Data;

namespace Aula04_01.Repository
{
    public class ProductRepository
    {
        public void Save (Product customer)
        {
            DataSet.Products.Add (customer);
        }

        public Product Retrieve(int id)
        {
            foreach (var c in DataSet.Products) 
            {
                if( c.ProductId == id )
                {
                    return c;
                }

            }

            return null;
        }
    }
}
    
