using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BNState.Domain.Data.Migrations
{
    public partial class jiomL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "Category9s",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "Category8s",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "Category7s",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "Category6s",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "Category5s",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "Category4s",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "Category3s",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "Category2s",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Order",
                table: "Category9s");

            migrationBuilder.DropColumn(
                name: "Order",
                table: "Category8s");

            migrationBuilder.DropColumn(
                name: "Order",
                table: "Category7s");

            migrationBuilder.DropColumn(
                name: "Order",
                table: "Category6s");

            migrationBuilder.DropColumn(
                name: "Order",
                table: "Category5s");

            migrationBuilder.DropColumn(
                name: "Order",
                table: "Category4s");

            migrationBuilder.DropColumn(
                name: "Order",
                table: "Category3s");

            migrationBuilder.DropColumn(
                name: "Order",
                table: "Category2s");
        }
    }
}
