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
            get {
                TimeSpan ts;
                if (EmploymentEndDate != null)
                 ts =  (DateTime)EmploymentEndDate - EmployementStartDate;
                else
                    ts =  DateTime.Today - EmployementStartDate;
                return ts.TotalDays;
                    }
        }
    }
}