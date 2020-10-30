using Microsoft.EntityFrameworkCore.Migrations;

namespace InnoflowServer.Infrastructure.Data.Migrations
{
    public partial class SecondMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "JobCategories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Andersen" });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[] { 1, "Admin" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "FirstName", "LastName", "Password", "RoleId" },
                values: new object[] { 1, "zdit@mail.ru", "Anton", "Zdit", "1234", 1 });

            migrationBuilder.InsertData(
                table: "UserJobCategories",
                columns: new[] { "UserId", "JobCaregorieId", "Id" },
                values: new object[] { 1, 1, 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserJobCategories",
                keyColumns: new[] { "UserId", "JobCaregorieId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "JobCategories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
