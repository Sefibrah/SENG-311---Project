using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace lab2.Migrations
{
    /// <inheritdoc />
    public partial class AddCompaniesSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Zipcode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    City = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Country = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "City", "Country", "Name", "Zipcode" },
                values: new object[,]
                {
                    { 1, "City1", "Country1", "Company1", "12345" },
                    { 2, "City2", "Country2", "Company2", "54321" },
                    { 3, "City3", "Country3", "Company3", "75643" },
                    { 4, "City4", "Country4", "Company4", "01232" },
                    { 5, "City5", "Country5", "Company5", "65100" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
