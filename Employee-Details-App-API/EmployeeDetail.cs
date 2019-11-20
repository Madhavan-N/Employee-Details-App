using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Details_App
{
	public class EmployeeDetail
	{
		public Guid EmployeeGuid { get; set; }
		public int EmployeeId { get; set; }
		public string Name { get; set; }
		public string Email { get; set; }
		public string MobileNumber { get; set; }
		public string Address { get; set; }
	}
}
