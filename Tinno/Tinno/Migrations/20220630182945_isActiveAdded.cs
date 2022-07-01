using Microsoft.EntityFrameworkCore.Migrations;

namespace Tinno.Migrations
{
    public partial class isActiveAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsTeam",
                table: "AspNetUsers",
                newName: "IsActive");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "AspNetUsers",
                newName: "IsTeam");
        }
    }
}
