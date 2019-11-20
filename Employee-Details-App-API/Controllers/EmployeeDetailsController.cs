using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Employee_Details_App.DataLayer;
using Employee_Details_App.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Employee_Details_App.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class EmployeeDetailsController : ControllerBase
	{
		private IEmployeeFacade employeeFacade;
		public EmployeeDetailsController(IEmployeeFacade _employeeFacade)
		{
			employeeFacade = _employeeFacade;
		}

		[HttpGet]
		public IActionResult Get()
		{
			var employeeDetails = employeeFacade.GetEmployeeDetails();
			if(employeeDetails==null|| employeeDetails.Count() == 0)
			{
				return new NotFoundResult();
			}
			return Ok(employeeFacade.GetEmployeeDetails());
		}

		[HttpGet("{employeeGuid}", Name = "Get")]
		public IActionResult Get(Guid employeeGuid)
		{
			var employeeDetails = employeeFacade.GetEmployeeDetailById(employeeGuid);
			if (employeeDetails == null)
			{
				return new NotFoundResult();
			}
			return Ok(employeeFacade.GetEmployeeDetailById(employeeGuid));
		}

	}
}
