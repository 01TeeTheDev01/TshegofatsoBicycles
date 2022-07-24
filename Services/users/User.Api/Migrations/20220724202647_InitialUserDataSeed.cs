using Microsoft.EntityFrameworkCore.Migrations;

namespace User.Api.Migrations
{
    public partial class InitialUserDataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiddleName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Age", "Email", "FirstName", "Gender", "LastName", "MiddleName", "PhoneNumber" },
                values: new object[,]
                {
                    { "CLI-4170", 34, "thabiso.mokoena.1@gmail.com", "Thabiso", "Male", "Mokoena", "", "0821231234" },
                    { "CLI-2028", 25, "werner.b.vanderhobis@gmail.com", "Bertus", "Male", "Van Der Hobis", "Werner", "0721231234" },
                    { "CLI-4993", 21, "matekane.m.1@icloud.com", "Mpho", "Female", "Matekane", "", "0731231234" },
                    { "CLI-5671", 34, "lee.dlamini4.1@icloud.com", "Lerato", "Female", "Dlamini", "", "0790791234" },
                    { "CLI-1887", 30, "fatima.jacobson10@outlook.com", "Fatima", "Female", "Jacobson", "", "0820824321" },
                    { "CLI-4190", 23, "jackson.mentjies@outlook.com", "Jackson", "Male", "Mentjies", "", "0741231234" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "Age", "Company", "Email", "FirstName", "Gender", "LastName", "MiddleName", "PhoneNumber", "Position" },
                values: new object[,]
                {
                    { "EMP-32160", 23, "TshegofatsoBicycles (Pty) Ltd", "j.mthethwa@tshegofatsobicycles.co.za", "Janice", "Female", "Mthethwa", "", "0111231234", "Sales Consultant" },
                    { "EMP-31154", 28, "TshegofatsoBicycles (Pty) Ltd", "t.mazibuko@tshegofatsobicycles.co.za", "Hopewell", "Male", "Mazibuko", "", "0111231234", "Bicycle Techician" },
                    { "EMP-66088", 33, "TshegofatsoBicycles (Pty) Ltd", "j.steenhuizen@tshegofatsobicycles.co.za", "Jeffrey", "Male", "Steenhuizen", "", "0111234321", "Bicycle Techician" },
                    { "EMP-23256", 23, "TshegofatsoBicycles (Pty) Ltd", "a.hartman@tshegofatsobicycles.co.za", "Antoinette", "Female", "Hartman", "", "0111232314", "Sales Consultant" },
                    { "EMP-59016", 32, "TshegofatsoBicycles (Pty) Ltd", "marcus.k.sibiya@tshegofatsobicycles.co.za", "Katlego", "Male", "Sibiya", "Marcus", "0111231234", "Sales Team Leader" },
                    { "EMP-37638", 26, "TshegofatsoBicycles (Pty) Ltd", "b.l.adams@tshegofatsobicycles.co.za", "Bernice", "Female", "Adams", "Logan", "0111233124", "Receptionist" },
                    { "EMP-84480", 28, "TshegofatsoBicycles (Pty) Ltd", "l.mudau@tshegofatsobicycles.co.za", "Lloyd", "Male", "Mudau", "", "0111235234", "Bicycle Techician" },
                    { "EMP-32443", 31, "TshegofatsoBicycles (Pty) Ltd", "t.mokobane@tshegofatsobicycles.co.za", "Tshegofatso", "Male", "Mokobane", "", "0820821234", "CEO" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
