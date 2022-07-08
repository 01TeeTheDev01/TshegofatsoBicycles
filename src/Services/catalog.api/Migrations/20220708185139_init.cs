using Microsoft.EntityFrameworkCore.Migrations;

namespace catalog.api.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Style = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Wheels = table.Column<int>(type: "int", nullable: false),
                    WheelSize = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Color", "Model", "Price", "Style", "WheelSize", "Wheels" },
                values: new object[] { "27d3443e-288a-4a7e-a6bb-c0e0f6ef11fc", "Raleigh", "Black", "Mongoose", 1799.99m, "BMX", 17, 2 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Color", "Model", "Price", "Style", "WheelSize", "Wheels" },
                values: new object[] { "4ab61802-e7ef-4a4e-ada7-5fb2d0759aa0", "Raleigh", "Red", "Panther", 2499.99m, "RACING", 22, 2 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Color", "Model", "Price", "Style", "WheelSize", "Wheels" },
                values: new object[] { "c506a5ef-404f-4e19-9f97-d3a446209782", "Armstring", "Silver", "Mongoose", 2999.99m, "RACING", 22, 2 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
