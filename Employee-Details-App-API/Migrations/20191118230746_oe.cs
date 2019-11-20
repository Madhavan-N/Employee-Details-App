using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Employee_Details_App.Migrations
{
    public partial class oe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EmployeeDetail",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeGuid = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    MobileNumber = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeDetail", x => x.EmployeeId);
                });

            migrationBuilder.InsertData(
                table: "EmployeeDetail",
                columns: new[] { "EmployeeId", "Address", "Email", "EmployeeGuid", "MobileNumber", "Name" },
                values: new object[] { 1, null, "Test@gmail.com", new Guid("11af177e-ad4d-4118-87c1-4bb3645054a0"), "7788990099", "Test Employee" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeDetail");
        }
    }
}
