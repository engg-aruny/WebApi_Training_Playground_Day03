using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi_Training_Playground_Day02.Models
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
