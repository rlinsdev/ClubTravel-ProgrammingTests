using System.Collections.Generic;
using System.Linq;
using Data.Interfaces;
using Entities;
using Data.Mock;
using System;

namespace Data
{
	public class TestRepository : ITestRepository
	{
		#region Constructor
		/// <summary>
		/// Initialize values
		/// </summary>
		public TestRepository()
		{
			IrishCompanies = new List<IrishCompany>();
			IrishCompanies.AddRange(CompanyMock.PopulateIrishCompanies());
			ForeignCompanies = new List<ForeignCompany>();
			ForeignCompanies.AddRange(CompanyMock.PopulateForeignCompanies());
			SoleTraders = new List<SoleTrader>();
			SoleTraders.AddRange(CompanyMock.PopulateSoleTraders());
		}
		#endregion

		public List<IrishCompany> IrishCompanies { get; set; }
		public List<ForeignCompany> ForeignCompanies { get; set; }
		public List<SoleTrader> SoleTraders { get; set; }
		public List<Employment> Employments { get; set; }

		#region FindIrishCompanies
		/// <summary>
		/// Irish Companies
		/// </summary>
		private List<IrishCompany> FindIrishCompanies()
		{
			return IrishCompanies.ToList();
		}
		#endregion

		#region FindSoleTraderCompanies
		/// <summary>
		/// Sale trades Companies
		/// </summary>
		private List<SoleTrader> FindSoleTraderCompanies()
		{
			return SoleTraders.ToList();
		}
		#endregion

		#region FindForeignCompanies
		/// <summary>
		/// Foreign Company
		/// </summary>
		private List<ForeignCompany> FindForeignCompanies()
		{
			return ForeignCompanies.ToList();
		}
		#endregion

		#region Find All Companies
		/// <summary>
		/// Return all companies in one list
		/// </summary>
		public List<Company> FindAllCompanies()
		{
			try
			{
				// Get specify values of companies
				var _irishCompany = FindIrishCompanies();
				var _soleTrderCompany = FindSoleTraderCompanies();
				var _foreignCompany = FindForeignCompanies();

				List<Company> _return = new List<Company>();

				// Add values
				_return.AddRange(_irishCompany);
				_return.AddRange(_soleTrderCompany);
				_return.AddRange(_foreignCompany);

				return _return;
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);

			}			
		}
		#endregion

		#region Sum Years All Employers
		/// <summary>
		/// Sum all ages of employers
		/// </summary>
		public double SumYearsAllEmployers()
		{
			EmployeeRepository _employeeRepository = new EmployeeRepository();
			return _employeeRepository.SumYearsEmployers(FindAllCompanies());
		}
		#endregion
	}
}
