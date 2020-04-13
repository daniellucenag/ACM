using Acme.Common;
using System;
using System.Collections.Generic;
namespace ACM.BL
{
    public class Customer : EntityBase, ILoggable
    {
        public Customer() : this(0)
        {

        }

        public Customer(int id)
        {
            Id = id;
            AddressList = new List<Address>();
        }

        public List<Address> AddressList { get; set; }
        public int Id { get; private set; }
        public string EmailAdress { get; set; }
        public string FirstName { get; set; }
        public string FullName
        {
            get
            {
                string fullName = LastName;
                if (!string.IsNullOrWhiteSpace(FirstName))
                {
                    if(!string.IsNullOrWhiteSpace(LastName))
                    {
                        fullName += ", ";
                    }
                    fullName += FirstName;
                }

                return fullName;

            }
        }

        public static int InstanceCount { get; set; }

        private string _lastName;
        public string LastName
        { 
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public string Log() => $"{Id}: {FullName} Email: {EmailAdress} Status: {EntityState.ToString()}";

        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAdress)) isValid = false;

            return isValid;
        }
    }
}
