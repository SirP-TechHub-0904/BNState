using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BNState.Domain.Data.Migrations
{
    public partial class portal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ActiviatePortal",
                table: "Category9s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ActiviatePortal",
                table: "Category8s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ActiviatePortal",
                table: "Category7s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ActiviatePortal",
                table: "Category6s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ActiviatePortal",
                table: "Category5s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ActiviatePortal",
                table: "Category4s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ActiviatePortal",
                table: "Category3s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ActiviatePortal",
                table: "Category2s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ActiviatePortal",
                table: "Category1s",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActiviatePortal",
                table: "Category9s");

            migrationBuilder.DropColumn(
                name: "ActiviatePortal",
                table: "Category8s");

            migrationBuilder.DropColumn(
                name: "ActiviatePortal",
                table: "Category7s");

            migrationBuilder.DropColumn(
                name: "ActiviatePortal",
                table: "Category6s");

            migrationBuilder.DropColumn(
                name: "ActiviatePortal",
                table: "Category5s");

            migrationBuilder.DropColumn(
                name: "ActiviatePortal",
                table: "Category4s");

            migrationBuilder.DropColumn(
                name: "ActiviatePortal",
                table: "Category3s");

            migrationBuilder.DropColumn(
                name: "ActiviatePortal",
                table: "Category2s");

            migrationBuilder.DropColumn(
                name: "ActiviatePortal",
                table: "Category1s");
        }
    }
}
