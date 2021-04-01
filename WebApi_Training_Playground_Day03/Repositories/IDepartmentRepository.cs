using System.Collections.Generic;
using WebApi_Training_Playground_Day03.Models;

namespace WebApi_Training_Playground_Day03.Repositories
{
	public interface IDepartmentRepository
	{
		IEnumerable<Department> GetDepartments();
	}
}
