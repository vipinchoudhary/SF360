using System.Collections.Generic;

namespace Entities
{
    public class IrishCompany : Company
    {
        public string AddressLine1;
        public string AddressLine2;
        public string AddressLine3;
        public string AddressLine4;
        public string EmployerRegisteredNumber { get; set; }
    }
}