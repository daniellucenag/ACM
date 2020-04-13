using Acme.Common;

namespace ACM.BL
{
    public class Product : EntityBase, ILoggable
    {
        public Product()
        {

        }

        public Product(int id)
        {
            Id = id;
        }

        public int Id { get; set; }

        private string _Name;
        public string Name
        {
            get
            {
                return _Name.InsertSpaces();
            }
            set
            {
                _Name = value;
            }
        }
        public string Description { get; set; }
        public decimal? CurrentPrice { get; set; }

        public string Log() => $"{Id}: {Name} Detail: {Description} Status: {EntityState.ToString()}";

        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(Name)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }

    }
}
