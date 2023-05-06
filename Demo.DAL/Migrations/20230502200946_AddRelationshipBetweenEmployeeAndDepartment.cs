using Microsoft.EntityFrameworkCore.Migrations;

namespace Demo.DAL.Migrations
{
    public partial class AddRelationshipBetweenEmployeeAndDepartment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FKDepartment",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_FKDepartment",
                table: "Employees",
                column: "FKDepartment");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_FKDepartment",
                table: "Employees",
                column: "FKDepartment",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_FKDepartment",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_FKDepartment",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "FKDepartment",
                table: "Employees");
        }
    }
}
