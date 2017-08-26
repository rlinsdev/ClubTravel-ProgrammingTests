using System.Collections.Generic;

namespace Entities
{
	/// <summary>
	/// Abastract class - served to base to other clasess fo company
	/// </summary>
	public abstract class Company
	{
		public string Name { get; set; }

		public string AddressLine1;
		public string AddressLine2;
		public string AddressLine3;
		public string AddressLine4;

		public List<Employment> Employments { get; set; }
	}
}