using Microsoft.EntityFrameworkCore.Migrations;

namespace Staffinfo.Migrations
{
    public partial class FilePath : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ProfilePath",
                table: "Staffs",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProfilePath",
                table: "Staffs");
        }
    }
}
