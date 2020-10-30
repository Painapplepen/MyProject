using Microsoft.EntityFrameworkCore.Migrations;

namespace InnoflowServer.Infrastructure.Data.Migrations
{
    public partial class TherdMigrations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "UserJobCategories",
                keyColumns: new[] { "UserId", "JobCaregorieId" },
                keyValues: new object[] { 1, 1 },
                column: "Id",
                value: 1);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "UserJobCategories",
                keyColumns: new[] { "UserId", "JobCaregorieId" },
                keyValues: new object[] { 1, 1 },
                column: "Id",
                value: 0);
        }
    }
}
