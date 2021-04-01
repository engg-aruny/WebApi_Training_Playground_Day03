using System.Collections.Generic;
using System.Linq;
using WebApi_Training_Playground_Day03.Data;
using WebApi_Training_Playground_Day03.Models;

namespace WebApi_Training_Playground_Day03.Repositories
{
	public class DepartmentRepository : IDepartmentRepository
	{
		private readonly WebApiTrainingDbContext _context;

		public DepartmentRepository(WebApiTrainingDbContext context)
		{
			this._context = context;
		}

		public IEnumerable<Department> GetDepartments()
		{
			return this._context.Departments.ToList();
		}
	}
}
