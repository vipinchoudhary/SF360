using Entities.Interfaces;
using System.Collections.Generic;

namespace Entities
{
    public class Company : IAddress
    {

        public string Name { get; set; }

        public List<Employment> Employments { get; set; }

        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public string AddressLine4 { get; set; }

        public void SetAddressLine1(string addressLine1, string addressLine2, string addressLine3, string addressLine4)
        {
            this.AddressLine1 = addressLine1;
            this.AddressLine2 = addressLine2;
            this.AddressLine3 = addressLine3;
            this.AddressLine4 = addressLine4;
        }

    }
}
