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
                var totalDays = ts.TotalDays;
                var totalYears = Math.Truncate(totalDays / 365);
                var totalMonths = Math.Truncate((totalDays % 365) / 30);
                return totalYears+totalMonths/10;
                    }
        }
    }
}