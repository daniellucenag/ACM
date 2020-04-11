using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class AddressRepository
    {
        public Address Retrieve(int id)
        {
            Address address = new Address(id);

            if (address.Id == 1)
            {
                address.StreetLine1 = "Sorocaba";
                address.StreetLine2 = "714 casa 1";
                address.City = "Belo Horizonte";
                address.State = "MG";
                address.Country = "Brazil";
                address.PostalCode = "31573020";
            }

            return address;
        }

        public IEnumerable<Address> RetrieveByCostumerId(int id)
        {
            var addressList = new List<Address>();

            Address address = new Address(1)
            {
                StreetLine1 = "Sorocaba",
                StreetLine2 = "714 casa 1",
                City = "Belo Horizonte",
                State = "MG",
                Country = "Brazil",
                PostalCode = "31573020",
            };

            addressList.Add(address);

            address = new Address(2)
            {
                StreetLine1 = "Sorocaba",
                StreetLine2 = "714 casa 1",
                City = "Belo Horizonte",
                State = "MG",
                Country = "Brazil",
                PostalCode = "31573020",
            };

            addressList.Add(address);

            return addressList;
        }

        public bool Save(Address address)
        {
            return true;
        }
    }
}
