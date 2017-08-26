using System.Web.Http;
using Data;

namespace webApp.Controller
{
	public class EmployeeController : ApiController
	{
		[Route("api/sumemployeeage")]
		[HttpGet]
		public double EmployeesByCompanyName()
		{
			TestRepository _repository = new TestRepository();
			return _repository.SumYearsAllEmployers();
		}
	}
}