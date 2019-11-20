using Employee_Details_App.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Details_App.Services
{
	public class EmployeeFacade : IEmployeeFacade
	{
		private AppDbContext dbContext;
		public EmployeeFacade(AppDbContext _dbContext)
		{
			dbContext = _dbContext;
		}
		public EmployeeDetail GetEmployeeDetailById(Guid EmployeeGuid)
		{
			var employeeDetail = dbContext.EmployeeDetails.Where(_ => _.EmployeeGuid == EmployeeGuid).FirstOrDefault();
			return new EmployeeDetail()
			{
				EmployeeId = employeeDetail.EmployeeId,
				EmployeeGuid = employeeDetail.EmployeeGuid,
				Email = employeeDetail.Email,
				Name = employeeDetail.Name,
				MobileNumber = employeeDetail.MobileNumber,
				Address = employeeDetail.Address
			};
		}

		public IEnumerable<EmployeeDetail> GetEmployeeDetails()
		{
			List<EmployeeDetail> employeeDetails = new List<EmployeeDetail>();
			foreach(var employeeDetail in dbContext.EmployeeDetails)
			{
				employeeDetails.Add(new EmployeeDetail()
				{
					EmployeeId = employeeDetail.EmployeeId,
					EmployeeGuid = employeeDetail.EmployeeGuid,
					Email = employeeDetail.Email,
					Name = employeeDetail.Name,
					MobileNumber = employeeDetail.MobileNumber,
					Address = employeeDetail.Address
				});
			}
			return employeeDetails;
		}
	}
}
