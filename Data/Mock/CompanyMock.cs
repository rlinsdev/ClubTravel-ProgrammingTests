using System;
using System.Collections.Generic;
using Entities;

namespace Data.Mock
{
	public static class CompanyMock
	{
		#region Mock data - Simulate a DataBase

		#region Populate Irish Companies
		/// <summary>
		/// Return data of Irish Companies
		/// </summary>
		public static IEnumerable<IrishCompany> PopulateIrishCompanies()
		{
			var comp1 = new IrishCompany
			{
				Name = "Irish1",
				AddressLine1 = "addr1",
				AddressLine2 = "addr2",
				AddressLine3 = "addr3"
				,
				Employments = new List<Employment>
				{
					new Employment
					{
						Employee = new Person
						{
							Name = "Employee15",
						},
						EmploymentStartDate = Convert.ToDateTime("10/10/2010"),
						EmploymentEndDate = Convert.ToDateTime("10/10/2012"),
					},
					new Employment
					{
						Employee = new Person
						{
							Name = "Employee16",
						},
						EmploymentStartDate = Convert.ToDateTime("10/10/2012"),
						EmploymentEndDate = Convert.ToDateTime("10/10/2014"),
					},
					new Employment
					{
						Employee = new Person
						{
							Name = "Employee17",
						},
						EmploymentStartDate = Convert.ToDateTime("10/10/2000"),
						EmploymentEndDate = null,
					}
				}
			};

			var comp2 = new IrishCompany
			{
				Name = "Irish2",
				AddressLine1 = "addr1",
				AddressLine2 = "addr2",
				AddressLine3 = "addr3"
			};

			var comp3 = new IrishCompany
			{
				Name = "Irish3",
				AddressLine1 = "addr1",
				AddressLine2 = "addr2",
				AddressLine3 = "addr3"
			};

			var comp4 = new IrishCompany
			{
				Name = "Irish4",
				AddressLine1 = "addr1",
				AddressLine2 = "addr2",
				AddressLine3 = "addr3"
			};

			return new List<IrishCompany> { comp1, comp2, comp3, comp4 };
		}
		#endregion

		#region Populate Foreign Companies
		/// <summary>
		/// Return data of Foreign Companies
		/// </summary>
		public static IEnumerable<ForeignCompany> PopulateForeignCompanies()
		{
			var comp1 = new ForeignCompany
			{
				Name = "Foreign1",
				AddressLine1 = "addr1",
				AddressLine2 = "addr2",
				AddressLine3 = "addr3"
				,
				Employments = new List<Employment>
				{
					new Employment
					{
						Employee = new Person
						{
							Name = "Employee9",
						},
						EmploymentStartDate = Convert.ToDateTime("10/10/2010"),
						EmploymentEndDate = Convert.ToDateTime("10/10/2012"),
					},
					new Employment
					{
						Employee = new Person
						{
							Name = "Employee10",
						},
						EmploymentStartDate = Convert.ToDateTime("10/10/2012"),
						EmploymentEndDate = Convert.ToDateTime("10/10/2014"),
					},
					new Employment
					{
						Employee = new Person
						{
							Name = "Employee11",
						},
						EmploymentStartDate = Convert.ToDateTime("10/10/2000"),
						EmploymentEndDate = null,
					}
				}
			};

			var comp2 = new ForeignCompany
			{
				Name = "Foreign2",
				AddressLine1 = "addr1",
				AddressLine2 = "addr2",
				AddressLine3 = "addr3"
				,
				Employments = new List<Employment>
				{
					new Employment
					{
						Employee = new Person
						{
							Name = "Employee4",
						},
						EmploymentStartDate = Convert.ToDateTime("10/10/2012"),
						EmploymentEndDate = null,
					},
					new Employment
					{
						Employee = new Person
						{
							Name = "Employee5",
						},
						EmploymentStartDate = Convert.ToDateTime("10/10/2004"),
						EmploymentEndDate = null,
					},
					new Employment
					{
						Employee = new Person
						{
							Name = "Employee6",
						},
						EmploymentStartDate = Convert.ToDateTime("10/10/2000"),
						EmploymentEndDate = Convert.ToDateTime("10/10/2003"),
					}
				}
			};

			return new List<ForeignCompany> { comp1, comp2 };
		}

		#endregion

		#region Populate Sole Traders
		/// <summary>
		/// Return data of Sole Trader Companies
		/// </summary>
		public static IEnumerable<SoleTrader> PopulateSoleTraders()
		{
			var comp1 = new SoleTrader
			{
				Name = "SoleTrader1",
				AddressLine1 = "addr1",
				AddressLine2 = "addr2",
				AddressLine3 = "addr3"
				,
				Employments = new List<Employment>
				{
					new Employment
					{
						Employee = new Person
						{
							Name = "Employee1",
						},
						EmploymentStartDate = Convert.ToDateTime("10/10/2000"),
						EmploymentEndDate = Convert.ToDateTime("10/10/2013"),
					},
					new Employment
					{
						Employee = new Person
						{
							Name = "Employee2",
						},
						EmploymentStartDate = Convert.ToDateTime("10/10/1988"),
						EmploymentEndDate = Convert.ToDateTime("10/10/2003"),
					},
					new Employment
					{
						Employee = new Person
						{
							Name = "Employee3",
						},
						EmploymentStartDate = Convert.ToDateTime("10/10/2005"),
						EmploymentEndDate = null,
					}
				}
			};

			return new List<SoleTrader> { comp1 };
		}

		#endregion

		#endregion
	}
}
