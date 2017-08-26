using System.Collections.Generic;
using System.Web.Http;
using Entities;
using Data;

namespace webApp.Controller
{
   public class CompanyController : ApiController
   {
		[Route("api/allcompanies")]
		[HttpGet]
		public List<Company> GelAllIrishCompany()
		{
			TestRepository _repository = new TestRepository();

			var _return = _repository.FindAllCompanies();
			return _return;
		}
	}
}