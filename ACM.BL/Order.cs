using Acme.Common;
using System;

namespace ACM.BL
{
    public class Order : EntityBase, ILoggable
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

        public string Log() => $"{Id}: Date: {this.Date.Value.Date} : Status {this.EntityState.ToString()}";

        public override bool Validate()
        {
            var isValid = true;

            if (Date == null) isValid = false;

            return isValid;
        }

    }
}
