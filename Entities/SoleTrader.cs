﻿using System.Collections.Generic;

namespace Entities
{
    /// <summary>
    /// </summary>
    public class SoleTrader
    {
        public string Name { get; set; }
        public string AddressLine1;
        public string AddressLine2;
        public string AddressLine3;
        public string AddressLine4;
        public List<Employment> Employments { get; set; }
    }
}