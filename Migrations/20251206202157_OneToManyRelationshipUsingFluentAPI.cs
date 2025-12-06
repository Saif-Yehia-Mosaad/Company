using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Company.Migrations
{
    /// <inheritdoc />
    public partial class OneToManyRelationshipUsingFluentAPI : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DepartmentDeptId",
                schema: "dbo",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "DepartmentDeptId",
                schema: "dbo",
                table: "Employees",
                newName: "DepartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_DepartmentDeptId",
                schema: "dbo",
                table: "Employees",
                newName: "IX_Employees_DepartmentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DepartmentId",
                schema: "dbo",
                table: "Employees",
                column: "DepartmentId",
                principalSchema: "dbo",
                principalTable: "Departments",
                principalColumn: "DeptId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DepartmentId",
                schema: "dbo",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "DepartmentId",
                schema: "dbo",
                table: "Employees",
                newName: "DepartmentDeptId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_DepartmentId",
                schema: "dbo",
                table: "Employees",
                newName: "IX_Employees_DepartmentDeptId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DepartmentDeptId",
                schema: "dbo",
                table: "Employees",
                column: "DepartmentDeptId",
                principalSchema: "dbo",
                principalTable: "Departments",
                principalColumn: "DeptId");
        }
    }
}
