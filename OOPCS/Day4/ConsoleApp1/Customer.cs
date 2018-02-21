using System;
using System.Collections.Generic;
using System.Text;

namespace ISSBank
{
    class Customer
    {
        
        public string NameCustomer { get; }
        public string AddressCustomer { get; }
        public string IDCustomer { get; }
        public int CustomerAge { get; }
        
        public Customer() : this("No Name","No Address", "No ID", new DateTime()){}
        public Customer(string namecustomer, string addresscustomer, string idcustomer, DateTime dateTime)
        {
            NameCustomer = namecustomer;
            AddressCustomer = addresscustomer;
            IDCustomer = idcustomer;
            AgeCustomer = DateTime.Now.Year - dateTime.Year;
        }
        
    }
}
