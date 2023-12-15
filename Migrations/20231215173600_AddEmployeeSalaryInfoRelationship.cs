using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lab2.Migrations
{
    /// <inheritdoc />
    public partial class AddEmployeeSalaryInfoRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SalaryInfoId",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "SalaryInfoId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "SalaryInfoId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "SalaryInfoId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                column: "SalaryInfoId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                column: "SalaryInfoId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                column: "SalaryInfoId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                column: "SalaryInfoId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                column: "SalaryInfoId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_SalaryInfoId",
                table: "Employees",
                column: "SalaryInfoId",
                unique: true,
                filter: "[SalaryInfoId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_SalaryInfos_SalaryInfoId",
                table: "Employees",
                column: "SalaryInfoId",
                principalTable: "SalaryInfos",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_SalaryInfos_SalaryInfoId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_SalaryInfoId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "SalaryInfoId",
                table: "Employees");
        }
    }
}
