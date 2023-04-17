using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BNState.Domain.Data.Migrations
{
    public partial class jiom : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "OgLevel9s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "OgLevel8s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "OgLevel7s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "OgLevel6s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "OgLevel5s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "OgLevel4s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "OgLevel3s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "OgLevel2s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Color",
                table: "OgLevel1s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Color",
                table: "OgLevel9s");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "OgLevel8s");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "OgLevel7s");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "OgLevel6s");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "OgLevel5s");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "OgLevel4s");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "OgLevel3s");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "OgLevel2s");

            migrationBuilder.DropColumn(
                name: "Color",
                table: "OgLevel1s");
        }
    }
}
