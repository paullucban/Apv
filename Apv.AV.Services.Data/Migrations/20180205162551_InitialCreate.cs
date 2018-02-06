using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Apv.AV.Services.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Versions",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    createdBy = table.Column<string>(nullable: true),
                    createdDt = table.Column<DateTime>(nullable: false),
                    downloadUrl = table.Column<string>(nullable: true),
                    features = table.Column<string>(nullable: true),
                    forceUpgrade = table.Column<bool>(nullable: false),
                    lastUpdatedBy = table.Column<string>(nullable: true),
                    lastUpdatedDt = table.Column<DateTime>(nullable: false),
                    newVersionCode = table.Column<decimal>(nullable: false),
                    platform = table.Column<string>(nullable: true),
                    prevVersionCode = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Versions", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Versions");
        }
    }
}
