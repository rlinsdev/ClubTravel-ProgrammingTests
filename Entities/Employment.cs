using System;

namespace Entities
{
    public class Employment
    {
        public Person Employee { get; set; }

        public DateTime EmploymentStartDate { get; set; }

        public DateTime? EmploymentEndDate { get; set; }

        /// <summary>
        /// Calculate the value of years employed
        /// </summary>
        /// <returns></returns>
        public double NumberOfYearsEmployed
        {
            get { return (EmploymentEndDate.HasValue == false ? DateTime.Now.Year - EmploymentStartDate.Year
					: EmploymentEndDate.Value.Year - EmploymentStartDate.Year); }
        }
    }
}
