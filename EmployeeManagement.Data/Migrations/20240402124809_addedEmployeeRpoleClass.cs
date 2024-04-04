using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EmployeeManagement.Data.Migrations
{
    /// <inheritdoc />
    public partial class addedEmployeeRpoleClass : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeRole_Employees_EmployeeListEmployeeId",
                table: "EmployeeRole");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeRole_Roles_RoleListRoleId",
                table: "EmployeeRole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeRole",
                table: "EmployeeRole");

            migrationBuilder.DropColumn(
                name: "DateOfRoleEntry",
                table: "Roles");

            migrationBuilder.RenameColumn(
                name: "RoleListRoleId",
                table: "EmployeeRole",
                newName: "RoleId");

            migrationBuilder.RenameColumn(
                name: "EmployeeListEmployeeId",
                table: "EmployeeRole",
                newName: "EmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeRole_RoleListRoleId",
                table: "EmployeeRole",
                newName: "IX_EmployeeRole_RoleId");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeRoleId",
                table: "EmployeeRole",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfRoleEntry",
                table: "EmployeeRole",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeRole",
                table: "EmployeeRole",
                column: "EmployeeRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeRole_EmployeeId",
                table: "EmployeeRole",
                column: "EmployeeId");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeRole_Employees_EmployeeId",
                table: "EmployeeRole",
                column: "EmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeRole_Roles_RoleId",
                table: "EmployeeRole",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "RoleId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeRole_Employees_EmployeeId",
                table: "EmployeeRole");

            migrationBuilder.DropForeignKey(
                name: "FK_EmployeeRole_Roles_RoleId",
                table: "EmployeeRole");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmployeeRole",
                table: "EmployeeRole");

            migrationBuilder.DropIndex(
                name: "IX_EmployeeRole_EmployeeId",
                table: "EmployeeRole");

            migrationBuilder.DropColumn(
                name: "EmployeeRoleId",
                table: "EmployeeRole");

            migrationBuilder.DropColumn(
                name: "DateOfRoleEntry",
                table: "EmployeeRole");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "EmployeeRole",
                newName: "RoleListRoleId");

            migrationBuilder.RenameColumn(
                name: "EmployeeId",
                table: "EmployeeRole",
                newName: "EmployeeListEmployeeId");

            migrationBuilder.RenameIndex(
                name: "IX_EmployeeRole_RoleId",
                table: "EmployeeRole",
                newName: "IX_EmployeeRole_RoleListRoleId");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateOfRoleEntry",
                table: "Roles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmployeeRole",
                table: "EmployeeRole",
                columns: new[] { "EmployeeListEmployeeId", "RoleListRoleId" });

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeRole_Employees_EmployeeListEmployeeId",
                table: "EmployeeRole",
                column: "EmployeeListEmployeeId",
                principalTable: "Employees",
                principalColumn: "EmployeeId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeRole_Roles_RoleListRoleId",
                table: "EmployeeRole",
                column: "RoleListRoleId",
                principalTable: "Roles",
                principalColumn: "RoleId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
