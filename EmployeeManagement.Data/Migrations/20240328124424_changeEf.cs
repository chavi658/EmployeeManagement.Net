using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagement.Data.Migrations
{
    /// <inheritdoc />
    public partial class changeEf : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Employees_EmployeeId",
                table: "Roles");

            migrationBuilder.DropIndex(
                name: "IX_Roles_EmployeeId",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Roles");

            migrationBuilder.CreateTable(
                name: "EmployeeRole",
                columns: table => new
                {
                    EmployeeListEmployeeId = table.Column<int>(type: "int", nullable: false),
                    RoleListRoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeRole", x => new { x.EmployeeListEmployeeId, x.RoleListRoleId });
                    table.ForeignKey(
                        name: "FK_EmployeeRole_Employees_EmployeeListEmployeeId",
                        column: x => x.EmployeeListEmployeeId,
                        principalTable: "Employees",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeRole_Roles_RoleListRoleId",
                        column: x => x.RoleListRoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeRole_RoleListRoleId",
                table: "EmployeeRole",
                column: "RoleListRoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmployeeRole");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Roles",
                type: "int",
                nullable: true);

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
    }
}
