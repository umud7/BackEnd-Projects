using Microsoft.EntityFrameworkCore.Migrations;

namespace Innab.Migrations
{
    public partial class addCounterTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Counters",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Count = table.Column<string>(nullable: true),
                    Telim = table.Column<string>(nullable: true),
                    Telebe = table.Column<string>(nullable: true),
                    KorporativPartnyor = table.Column<string>(nullable: true),
                    TelimNovu = table.Column<string>(nullable: true),
                    VideoDerslik = table.Column<string>(nullable: true),
                    Meqale = table.Column<string>(nullable: true),
                    SaytZiyareti = table.Column<string>(nullable: true),
                    IsleTeminEdilme = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Counters", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Counters");
        }
    }
}
