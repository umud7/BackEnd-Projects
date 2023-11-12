﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace EduTech2.Migrations
{
    public partial class addFeatureTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Features",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeatureName = table.Column<string>(nullable: true),
                    FeatureDesc = table.Column<string>(nullable: true),
                    Icon = table.Column<string>(nullable: true),
                    SectionName = table.Column<string>(nullable: true),
                    SectionDesc = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Features", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Features");
        }
    }
}
