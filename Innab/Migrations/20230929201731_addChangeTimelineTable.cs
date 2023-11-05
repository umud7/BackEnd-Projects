using Microsoft.EntityFrameworkCore.Migrations;

namespace Innab.Migrations
{
    public partial class addChangeTimelineTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IsRight",
                table: "Timelines",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsRight",
                table: "Timelines");
        }
    }
}
