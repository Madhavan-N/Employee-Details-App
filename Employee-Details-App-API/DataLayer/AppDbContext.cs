using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee_Details_App.DataLayer
{
	public class AppDbContext : DbContext
	{
		public DbSet<EmployeeDetail> EmployeeDetails { get; set; }
		public AppDbContext(DbContextOptions<AppDbContext> options)
			: base(options)
		{
			Database.Migrate();
			Database.EnsureCreated();
		}
		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<EmployeeDetail>().HasKey(_ => _.EmployeeId);
			SeedData(modelBuilder);
		}


		private void SeedData(ModelBuilder modelBuilder)
		{
			modelBuilder
				.Entity<EmployeeDetail>()
				.HasData(
				new EmployeeDetail[]
				{
					new EmployeeDetail()
					{
						EmployeeGuid = Guid.Parse("{11AF177E-AD4D-4118-87C1-4BB3645054A0}"),
						EmployeeId=1,
						Name="Test Employee",
						Email="Test@gmail.com",
						MobileNumber="7788990099"
					},
					new EmployeeDetail()
					{
						EmployeeGuid = Guid.Parse("{dc25d6eb-0230-4069-898e-18c7724f7901}"),
						EmployeeId=2,
						Name="Test Employee 2",
						Email="Test2@gmail.com",
						MobileNumber="8899009977"
					}
				});
		}
	}
}
