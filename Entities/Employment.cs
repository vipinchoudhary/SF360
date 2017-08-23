using System;

namespace Entities
{
    public class Employment
    {
        public Person Employee { get; set; }

        public DateTime EmployementStartDate { get; set; }

        public DateTime? EmploymentEndDate { get; set; }

       
        public double NumberOfYearsEmployed
        {
            get { return 0; }
        }
    }
}