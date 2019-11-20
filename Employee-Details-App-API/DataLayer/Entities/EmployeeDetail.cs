using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Details_App.DataLayer.Entities
{
	[Table("EmployeeDetails")]
	public class EmployeeDetail
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Int64 EmployeeId { get; set; }

		[Required]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public Guid EmployeeGuid { get; set; }

		[Required]
		[MaxLength(254)]
		public string Name { get; set; }

		[MaxLength(254)]
		public string Email { get; set; }

		[MaxLength(15)]
		public string MobileNumber { get; set; }
		public string Address { get; set; }
	}
}
