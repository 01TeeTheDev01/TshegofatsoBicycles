using Microsoft.EntityFrameworkCore.Migrations;

namespace catalog.api.Migrations
{
    public partial class InitialSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "27d3443e-288a-4a7e-a6bb-c0e0f6ef11fc");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "4ab61802-e7ef-4a4e-ada7-5fb2d0759aa0");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "c506a5ef-404f-4e19-9f97-d3a446209782");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "Color", "Model", "Price", "Style", "WheelSize", "Wheels" },
                values: new object[,]
                {
                    { "f920e320-98c8-4b44-bcb1-f12de882aab4", "Raleigh", "Black", "Mongoose", 1799.99m, "BMX", 17, 2 },
                    { "69f0858b-718e-410b-9c9c-86e02cf407d9", "Raleigh", "Red", "Panther", 2499.99m, "RACING", 22, 2 },
                    { "24b6a7de-9a97-4f8f-a2ad-a58c73ffd229", "Armstrong", "Silver", "Mongoose", 2999.99m, "RACING", 22, 2 },
                    { "2ace51d8-ca56-41ff-a74a-93c750092079", "Peagot", "Silver-Gray", "Sprinter-X2", 1299.99m, "BMX", 17, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "24b6a7de-9a97-4f8f-a2ad-a58c73ffd229");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "2ace51d8-ca56-41ff-a74a-93c750092079");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "69f0858b-718e-410b-9c9c-86e02cf407d9");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: "f920e320-98c8-4b44-bcb1-f12de882aab4");

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
    }
}
