using System.Collections.Generic;

namespace Entities
{
    public class ForeignCompany
    {
        public string AddressLine1;
        public string AddressLine2;
        public string AddressLine3;
        public string AddressLine4;
        public string Name { get; set; }
        public List<Employment> Employments { get; set; }
        public string InternationBusinessNumber { get; set; }
    }
}