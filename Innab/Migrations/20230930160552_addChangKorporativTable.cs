using Microsoft.EntityFrameworkCore.Migrations;

namespace Innab.Migrations
{
    public partial class addChangKorporativTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Korporativs",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Korporativs");
        }
    }
}
