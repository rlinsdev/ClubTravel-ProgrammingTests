using System;
using System.Collections.Generic;
using System.Linq;
using Entities;

namespace Data
{
	public class EmployeeRepository
	{
		#region Sum Years Employers
		/// <summary>
		/// Realize sum of years employers - LINQ
		/// </summary>
		public double SumYearsEmployers(List<Company> lstCompany)
		{
			try
			{
				// Remove lst Companies without employments
				var _lstCompanyWithEmployments = lstCompany.Where(x => x.Employments != null);

				// Sum the years
				var _sumYears = _lstCompanyWithEmployments.Sum(
					n => n.Employments.Sum(
					y => y.NumberOfYearsEmployed));

				return _sumYears;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}			
		}
		#endregion
	}
}
