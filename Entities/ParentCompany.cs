using Entities.Interfaces;
using System.Collections.Generic;

namespace Entities
{
    public abstract class ParentCompany : IAddress
    {

        public string Name { get; set; }

        public List<Employment> Employments { get; set; }

        public string addressLine1;
        public string addressLine2;
        public string addressLine3;
        public string addressLine4;

        public string AddressLine1
        {
            get { return addressLine1; }
            set { addressLine1 = value; }
        }

        public string AddressLine2
        {
            get { return addressLine2; }
            set { addressLine2 = value; }
        }

        public string AddressLine3
        {
            get { return addressLine3; }
            set { addressLine3 = value; }
        }

        public string AddressLine4
        {
            get { return addressLine4; }
            set { addressLine4 = value; }
        }


    }
}
