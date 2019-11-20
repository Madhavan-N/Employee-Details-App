using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Details_App.Services
{
	public interface IEmployeeFacade
	{
		EmployeeDetail GetEmployeeDetailById(Guid EmployeeId);
		IEnumerable<EmployeeDetail> GetEmployeeDetails();
	}
}
