using System.Data.Entity;
using WebApi_Training_Playground_Day02.Models;

namespace WebApi_Training_Playground_Day02.Data
{
	public class WebApiTrainingDbContext : DbContext
	{
		public WebApiTrainingDbContext()
			: base("name=WebApiTrainingDb")
		{
		}

		public DbSet<Employee> Employees { get; set; }
	}
}
