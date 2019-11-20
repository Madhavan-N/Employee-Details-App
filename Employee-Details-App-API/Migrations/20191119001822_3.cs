using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Employee_Details_App.Migrations
{
    public partial class _3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "EmployeeDetails",
                columns: new[] { "EmployeeId", "Address", "Email", "EmployeeGuid", "MobileNumber", "Name" },
                values: new object[] { 2, null, "Test2@gmail.com", new Guid("dc25d6eb-0230-4069-898e-18c7724f7901"), "8899009977", "Test Employee 2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "EmployeeDetails",
                keyColumn: "EmployeeId",
                keyValue: 2);
        }
    }
}
