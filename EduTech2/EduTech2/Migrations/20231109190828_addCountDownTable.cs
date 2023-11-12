using Microsoft.EntityFrameworkCore.Migrations;

namespace EduTech2.Migrations
{
    public partial class addCountDownTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CountDowns",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Desc = table.Column<string>(nullable: true),
                    Days = table.Column<string>(nullable: true),
                    Hours = table.Column<string>(nullable: true),
                    Mins = table.Column<string>(nullable: true),
                    Secs = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountDowns", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CountDowns");
        }
    }
}
