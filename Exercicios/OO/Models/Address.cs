using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OO.Models
{
    public class Address
    {
        public int AddressID {get; set; }
        public string Street {get; set; }
        public string District {get; set; }
        public int Number {get; set; }
        public string City {get; set; }
        public string FederalState {get; set; }
        public string Country {get; set; }
        public string ZipCode {get; set; }
        public AddressType AddressType {get; set; }
    }
    //enum é um a especie de objeto simplificado
    public enum AddressType 
    {
        Commercial,
        Residential 
    }
}