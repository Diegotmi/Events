using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Events.DAL.Migrations
{
    public partial class itinial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AgeRanges",
                columns: table => new
                {
                    IdAgeRange = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    Description = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgeRanges", x => x.IdAgeRange);
                });

            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    IdEvent = table.Column<Guid>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    EndTime = table.Column<DateTime>(nullable: false),
                    EnvironmentsAmmount = table.Column<int>(nullable: false),
                    IdAgeRange = table.Column<int>(nullable: false),
                    IsOpenBar = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    StartTime = table.Column<DateTime>(nullable: false),
                    Venue = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Events", x => x.IdEvent);
                    table.ForeignKey(
                        name: "FK_Events_AgeRanges_IdAgeRange",
                        column: x => x.IdAgeRange,
                        principalTable: "AgeRanges",
                        principalColumn: "IdAgeRange",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Events_IdAgeRange",
                table: "Events",
                column: "IdAgeRange");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");

            migrationBuilder.DropTable(
                name: "AgeRanges");
        }
    }
}
