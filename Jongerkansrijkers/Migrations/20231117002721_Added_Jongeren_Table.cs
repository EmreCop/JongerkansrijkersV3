using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jongerkansrijkers.Migrations
{
    /// <inheritdoc />
    public partial class Added_Jongeren_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jongeren",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brithdate = table.Column<DateOnly>(type: "date", nullable: false),
                    InstutuutId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jongeren", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Jongeren_Instutuuts_InstutuutId",
                        column: x => x.InstutuutId,
                        principalTable: "Instutuuts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jongeren_InstutuutId",
                table: "Jongeren",
                column: "InstutuutId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jongeren");
        }
    }
}
