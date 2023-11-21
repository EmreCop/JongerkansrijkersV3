using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Jongerkansrijkers.Migrations
{
    /// <inheritdoc />
    public partial class Added_ActiVeit_Table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activiteiten_Jongeren_JongerenId",
                table: "Activiteiten");

            migrationBuilder.DropForeignKey(
                name: "FK_Activiteiten_Users_BegeleiderId",
                table: "Activiteiten");

            migrationBuilder.DropIndex(
                name: "IX_Activiteiten_JongerenId",
                table: "Activiteiten");

            migrationBuilder.DropColumn(
                name: "JongerenId",
                table: "Activiteiten");

            migrationBuilder.RenameColumn(
                name: "location",
                table: "Activiteiten",
                newName: "Location");

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Activiteiten",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Activiteiten",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Activiteiten",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateOnly>(
                name: "Date",
                table: "Activiteiten",
                type: "date",
                nullable: true,
                oldClrType: typeof(DateOnly),
                oldType: "date");

            migrationBuilder.AlterColumn<int>(
                name: "BegeleiderId",
                table: "Activiteiten",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "JongerenIds",
                table: "Activiteiten",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Activiteiten_Users_BegeleiderId",
                table: "Activiteiten",
                column: "BegeleiderId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activiteiten_Users_BegeleiderId",
                table: "Activiteiten");

            migrationBuilder.DropColumn(
                name: "JongerenIds",
                table: "Activiteiten");

            migrationBuilder.RenameColumn(
                name: "Location",
                table: "Activiteiten",
                newName: "location");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Activiteiten",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "location",
                table: "Activiteiten",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Activiteiten",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateOnly>(
                name: "Date",
                table: "Activiteiten",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1),
                oldClrType: typeof(DateOnly),
                oldType: "date",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BegeleiderId",
                table: "Activiteiten",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "JongerenId",
                table: "Activiteiten",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Activiteiten_JongerenId",
                table: "Activiteiten",
                column: "JongerenId");

            migrationBuilder.AddForeignKey(
                name: "FK_Activiteiten_Jongeren_JongerenId",
                table: "Activiteiten",
                column: "JongerenId",
                principalTable: "Jongeren",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Activiteiten_Users_BegeleiderId",
                table: "Activiteiten",
                column: "BegeleiderId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
