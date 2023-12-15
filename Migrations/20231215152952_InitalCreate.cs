using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace lab2.Migrations
{
    /// <inheritdoc />
    public partial class InitalCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Company",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zipcode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Company",
                columns: new[] { "Id", "City", "Country", "Name", "Zipcode" },
                values: new object[,]
                {
                    { 1, "City1", "Country1", "Company1", "12345" },
                    { 2, "City2", "Country2", "Company2", "54321" },
                    { 3, "City3", "Country3", "Company3", "75643" },
                    { 4, "City4", "Country4", "Company4", "01232" },
                    { 5, "City5", "Country5", "Company5", "65100" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "BirthDate", "CompanyId", "Image", "Name", "Position", "Surname" },
                values: new object[,]
                {
                    { 1, new DateTime(1992, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "/images/Martin.jpg", "Martin", "Marketing Expert", "Simpson" },
                    { 2, new DateTime(1995, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "/images/Jacob.jpg", "Jacob", "Manager", "Hawk" },
                    { 3, new DateTime(2000, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "/images/Elizabeth.jpg", "Elizabeth", "Software Engineer", "Geil" },
                    { 4, new DateTime(1997, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "/images/Kate.jpg", "Kate", "Admin", "Metain" },
                    { 5, new DateTime(1990, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "/images/Michael.jpg", "Michael", "Marketing expert", "Cook" },
                    { 6, new DateTime(2001, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "/images/John.jpg", "John", "Software Engineer", "Snow" },
                    { 7, new DateTime(1999, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "/images/Nina.jpg", "Nina", "Software Engineer", "Soprano" },
                    { 8, new DateTime(2000, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "/images/Tina.jpg", "Tina", "Team Leader", "Fins" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Company");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
