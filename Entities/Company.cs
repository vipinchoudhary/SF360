using Entities.Interfaces;
using System.Collections.Generic;

namespace Entities
{
    public  class Company 
    {
        
        public string Name { get; set; }

        public string Type { get; set; }

        public List<Employment> Employments { get; set; }        

    }
}
