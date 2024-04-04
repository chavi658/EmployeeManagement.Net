using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagement.Data.Migrations
{
    /// <inheritdoc />
    public partial class Second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Employees_EmployeeId1",
                table: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_Roles_EmployeeId1",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "EmployeeId1",
                table: "Roles");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "Roles",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_EmployeeId",
                table: "Roles",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_Employees_EmployeeId",
                table: "Roles",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Employees_EmployeeId",
                table: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_Roles_EmployeeId",
                table: "Roles");

            migrationBuilder.AlterColumn<string>(
                name: "EmployeeId",
                table: "Roles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId1",
                table: "Roles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Roles_EmployeeId1",
                table: "Roles",
                column: "EmployeeId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_Employees_EmployeeId1",
                table: "Roles",
                column: "EmployeeId1",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
