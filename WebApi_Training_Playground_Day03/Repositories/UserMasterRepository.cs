using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi_Training_Playground_Day03.Data;
using WebApi_Training_Playground_Day03.Models;

namespace WebApi_Training_Playground_Day03.Repositories
{
	public class UserMasterRepository : IUserMasterRepository
	{
		public UserMaster ValidateUser(string username, string password)
		{
			using (WebApiTrainingDbContext _context = new WebApiTrainingDbContext())
			{
				return _context.UserMasters.FirstOrDefault(user => user.UserName.Equals(username, StringComparison.OrdinalIgnoreCase)
																   && user.Password == password);
			}
		}
	}

	public interface IUserMasterRepository
	{
		UserMaster ValidateUser(string username, string password);
	}
}
