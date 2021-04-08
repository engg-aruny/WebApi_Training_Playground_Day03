using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using WebApi_Training_Playground_Day03.Models;
using WebApi_Training_Playground_Day03.Repositories;

namespace WebApi_Training_Playground_Day03.Controllers
{
	[Route("api/DepartmentDep")]
    public class DepartmentWithDependencyInjectionController: ApiController
    {
		private readonly IDepartmentRepository _departmentRepository;

		public DepartmentWithDependencyInjectionController(IDepartmentRepository departmentRepository)
	    {
		    this._departmentRepository = departmentRepository;
	    }

	    // GET: Department
	    [Authorize(Roles = "SuperAdmin, Admin, User")]
	    public IHttpActionResult GetDepartments()
	    {
		    IEnumerable<Department> departments = null;

		    departments = this._departmentRepository.GetDepartments().ToList();

		    if (!departments.Any())
		    {
			    return NotFound();
		    }

		    return Ok(departments);
	    }
	}
}
