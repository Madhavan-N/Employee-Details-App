using Microsoft.EntityFrameworkCore.Migrations;

namespace Employee_Details_App.Migrations
{
    public partial class two : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeDetail",
                table: "EmployeeDetail");

            migrationBuilder.RenameTable(
                name: "EmployeeDetail",
                newName: "EmployeeDetails");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeDetails",
                table: "EmployeeDetails",
                column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeDetails",
                table: "EmployeeDetails");

            migrationBuilder.RenameTable(
                name: "EmployeeDetails",
                newName: "EmployeeDetail");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeDetail",
                table: "EmployeeDetail",
                column: "EmployeeId");
        }
    }
}
