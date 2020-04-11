using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Order
    {
        public Order()
        {

        }

        public Order(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
        public DateTimeOffset? Date { get; set; }
        public bool Validate()
        {
            var isValid = true;

            if (Date == null) isValid = false;

            return isValid;
        }

    }
}
