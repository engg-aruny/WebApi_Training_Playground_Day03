using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApi_Training_Playground_Day03.Models
{
	[Table("UserMaster")]
	public class UserMaster
    {
	    [Key]
		public int Id { get; set; }

	    public string UserName { get; set; }

	    public string Password { get; set; }

	    public string Roles { get; set; }

	    public string EmailId { get; set; }
    }
}
