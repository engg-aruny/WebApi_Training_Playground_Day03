using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi_Training_Playground_Day02.Models;

namespace WebApi_Training_Playground_Day02.Repositories
{
	public interface IEmployeeRepository
	{
		IEnumerable<Employee> GetEmployees();

		Employee GetEmployee(int employeeId);

		Employee AddEmployee(Employee employee);

		Employee UpdateEmployee(Employee employee);

		void DeleteEmployee(int employeeId);
	}
}
