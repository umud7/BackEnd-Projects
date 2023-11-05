using Microsoft.EntityFrameworkCore.Migrations;

namespace Innab.Migrations
{
    public partial class addChangeCounterTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Count",
                table: "Counters");

            migrationBuilder.DropColumn(
                name: "IsleTeminEdilme",
                table: "Counters");

            migrationBuilder.DropColumn(
                name: "KorporativPartnyor",
                table: "Counters");

            migrationBuilder.DropColumn(
                name: "Meqale",
                table: "Counters");

            migrationBuilder.DropColumn(
                name: "SaytZiyareti",
                table: "Counters");

            migrationBuilder.DropColumn(
                name: "Telebe",
                table: "Counters");

            migrationBuilder.DropColumn(
                name: "Telim",
                table: "Counters");

            migrationBuilder.DropColumn(
                name: "TelimNovu",
                table: "Counters");

            migrationBuilder.DropColumn(
                name: "VideoDerslik",
                table: "Counters");

            migrationBuilder.AlterColumn<int>(
                name: "Target",
                table: "Counters",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Text",
                table: "Counters",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Text",
                table: "Counters");

            migrationBuilder.AlterColumn<string>(
                name: "Target",
                table: "Counters",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<string>(
                name: "Count",
                table: "Counters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IsleTeminEdilme",
                table: "Counters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "KorporativPartnyor",
                table: "Counters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Meqale",
                table: "Counters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SaytZiyareti",
                table: "Counters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telebe",
                table: "Counters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Telim",
                table: "Counters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TelimNovu",
                table: "Counters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "VideoDerslik",
                table: "Counters",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
