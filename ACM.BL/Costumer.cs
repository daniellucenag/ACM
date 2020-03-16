using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Costumer
    {
        public int CostumerId { get; private set; }
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
        private string _lastName;
        public string LastName
        { get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }
    }
}
