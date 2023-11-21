using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jongerkansrijkers.Migrations
{
    /// <inheritdoc />
    public partial class Added_Nuble_Jongeren : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jongeren_Instutuuts_InstutuutId",
                table: "Jongeren");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Jongeren",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "InstutuutId",
                table: "Jongeren",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Jongeren",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "Brithdate",
                table: "Jongeren",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AddForeignKey(
                name: "FK_Jongeren_Instutuuts_InstutuutId",
                table: "Jongeren",
                column: "InstutuutId",
                principalTable: "Instutuuts",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jongeren_Instutuuts_InstutuutId",
                table: "Jongeren");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Jongeren",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InstutuutId",
                table: "Jongeren",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Jongeren",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "Brithdate",
                table: "Jongeren",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1),
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Jongeren_Instutuuts_InstutuutId",
                table: "Jongeren",
                column: "InstutuutId",
                principalTable: "Instutuuts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
