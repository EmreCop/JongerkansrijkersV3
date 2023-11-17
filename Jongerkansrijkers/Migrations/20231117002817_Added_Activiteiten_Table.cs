using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jongerkansrijkers.Migrations
{
    /// <inheritdoc />
    public partial class Added_Activiteiten_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activiteiten",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateOnly>(type: "date", nullable: false),
                    JongerenId = table.Column<int>(type: "int", nullable: false),
                    BegeleiderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activiteiten", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Activiteiten_Jongeren_JongerenId",
                        column: x => x.JongerenId,
                        principalTable: "Jongeren",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Activiteiten_Users_BegeleiderId",
                        column: x => x.BegeleiderId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Activiteiten_BegeleiderId",
                table: "Activiteiten",
                column: "BegeleiderId");

            migrationBuilder.CreateIndex(
                name: "IX_Activiteiten_JongerenId",
                table: "Activiteiten",
                column: "JongerenId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Activiteiten");
        }
    }
}
