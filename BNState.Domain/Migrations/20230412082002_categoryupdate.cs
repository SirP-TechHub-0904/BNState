using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BNState.Domain.Data.Migrations
{
    public partial class categoryupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Key",
                table: "Category9s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LogoUrl",
                table: "Category9s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShowStatus",
                table: "Category9s",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Key",
                table: "Category8s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LogoUrl",
                table: "Category8s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShowStatus",
                table: "Category8s",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Key",
                table: "Category7s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LogoUrl",
                table: "Category7s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShowStatus",
                table: "Category7s",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Key",
                table: "Category6s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LogoUrl",
                table: "Category6s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShowStatus",
                table: "Category6s",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Key",
                table: "Category5s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LogoUrl",
                table: "Category5s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShowStatus",
                table: "Category5s",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Key",
                table: "Category4s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LogoUrl",
                table: "Category4s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShowStatus",
                table: "Category4s",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Key",
                table: "Category3s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LogoUrl",
                table: "Category3s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShowStatus",
                table: "Category3s",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Key",
                table: "Category2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LogoUrl",
                table: "Category2s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShowStatus",
                table: "Category2s",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Key",
                table: "Category1s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LogoUrl",
                table: "Category1s",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShowStatus",
                table: "Category1s",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Key",
                table: "Category9s");

            migrationBuilder.DropColumn(
                name: "LogoUrl",
                table: "Category9s");

            migrationBuilder.DropColumn(
                name: "ShowStatus",
                table: "Category9s");

            migrationBuilder.DropColumn(
                name: "Key",
                table: "Category8s");

            migrationBuilder.DropColumn(
                name: "LogoUrl",
                table: "Category8s");

            migrationBuilder.DropColumn(
                name: "ShowStatus",
                table: "Category8s");

            migrationBuilder.DropColumn(
                name: "Key",
                table: "Category7s");

            migrationBuilder.DropColumn(
                name: "LogoUrl",
                table: "Category7s");

            migrationBuilder.DropColumn(
                name: "ShowStatus",
                table: "Category7s");

            migrationBuilder.DropColumn(
                name: "Key",
                table: "Category6s");

            migrationBuilder.DropColumn(
                name: "LogoUrl",
                table: "Category6s");

            migrationBuilder.DropColumn(
                name: "ShowStatus",
                table: "Category6s");

            migrationBuilder.DropColumn(
                name: "Key",
                table: "Category5s");

            migrationBuilder.DropColumn(
                name: "LogoUrl",
                table: "Category5s");

            migrationBuilder.DropColumn(
                name: "ShowStatus",
                table: "Category5s");

            migrationBuilder.DropColumn(
                name: "Key",
                table: "Category4s");

            migrationBuilder.DropColumn(
                name: "LogoUrl",
                table: "Category4s");

            migrationBuilder.DropColumn(
                name: "ShowStatus",
                table: "Category4s");

            migrationBuilder.DropColumn(
                name: "Key",
                table: "Category3s");

            migrationBuilder.DropColumn(
                name: "LogoUrl",
                table: "Category3s");

            migrationBuilder.DropColumn(
                name: "ShowStatus",
                table: "Category3s");

            migrationBuilder.DropColumn(
                name: "Key",
                table: "Category2s");

            migrationBuilder.DropColumn(
                name: "LogoUrl",
                table: "Category2s");

            migrationBuilder.DropColumn(
                name: "ShowStatus",
                table: "Category2s");

            migrationBuilder.DropColumn(
                name: "Key",
                table: "Category1s");

            migrationBuilder.DropColumn(
                name: "LogoUrl",
                table: "Category1s");

            migrationBuilder.DropColumn(
                name: "ShowStatus",
                table: "Category1s");
        }
    }
}
