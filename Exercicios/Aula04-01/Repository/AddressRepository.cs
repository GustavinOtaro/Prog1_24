using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula04_01.Models;
using Aula04_01.Data;

namespace Aula04_01.Repository
{
    public class AddressRepository
    {
        public void Save (Address customer)
        {
            DataSet.Addresses.Add (customer);
        }

        public Address Retrieve(int id)
        {
            foreach (var c in DataSet.Addresses) 
            {
                if( c.Id == id )
                {
                    return c;
                }

            }

            return null;
        }
    }
}
    
