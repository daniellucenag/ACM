using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class CustomerRepository
    {
        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }

        private AddressRepository addressRepository { get; set; }
        
        public Customer Retrieve(int id)
        {
            Customer customer = new Customer(id);

            if (id == 1)
            {
                customer.EmailAdress = "fbaggins@hobbiton.me";
                customer.FirstName = "Bilbo";
                customer.LastName = "Baggins";
                customer.AddressList = addressRepository.RetrieveByCostumerId(1).ToList();
            }

            return customer;
        }

        
        public bool Save(Customer customer)
        {
            return true;
        }
    }
}
