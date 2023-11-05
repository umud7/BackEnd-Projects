using Microsoft.EntityFrameworkCore.Migrations;

namespace Innab.Migrations
{
    public partial class addChangeBioTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CopyRight",
                table: "Bios",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CopyRight",
                table: "Bios");
        }
    }
}
