using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BNState.Domain.Data.Migrations
{
    public partial class update0921 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "AddToDashboard",
                table: "Category9s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "DashboardOrder",
                table: "Category9s",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "OfficeCount",
                table: "Category9s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "UserCount",
                table: "Category9s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AddToDashboard",
                table: "Category8s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "DashboardOrder",
                table: "Category8s",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "OfficeCount",
                table: "Category8s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "UserCount",
                table: "Category8s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AddToDashboard",
                table: "Category7s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "DashboardOrder",
                table: "Category7s",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "OfficeCount",
                table: "Category7s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "UserCount",
                table: "Category7s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AddToDashboard",
                table: "Category6s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "DashboardOrder",
                table: "Category6s",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "OfficeCount",
                table: "Category6s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "UserCount",
                table: "Category6s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AddToDashboard",
                table: "Category5s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "DashboardOrder",
                table: "Category5s",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "OfficeCount",
                table: "Category5s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "UserCount",
                table: "Category5s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AddToDashboard",
                table: "Category4s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "DashboardOrder",
                table: "Category4s",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "OfficeCount",
                table: "Category4s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "UserCount",
                table: "Category4s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AddToDashboard",
                table: "Category3s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "DashboardOrder",
                table: "Category3s",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "OfficeCount",
                table: "Category3s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "UserCount",
                table: "Category3s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AddToDashboard",
                table: "Category2s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "DashboardOrder",
                table: "Category2s",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "OfficeCount",
                table: "Category2s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "UserCount",
                table: "Category2s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "AddToDashboard",
                table: "Category1s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "DashboardOrder",
                table: "Category1s",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "OfficeCount",
                table: "Category1s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "UserCount",
                table: "Category1s",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddToDashboard",
                table: "Category9s");

            migrationBuilder.DropColumn(
                name: "DashboardOrder",
                table: "Category9s");

            migrationBuilder.DropColumn(
                name: "OfficeCount",
                table: "Category9s");

            migrationBuilder.DropColumn(
                name: "UserCount",
                table: "Category9s");

            migrationBuilder.DropColumn(
                name: "AddToDashboard",
                table: "Category8s");

            migrationBuilder.DropColumn(
                name: "DashboardOrder",
                table: "Category8s");

            migrationBuilder.DropColumn(
                name: "OfficeCount",
                table: "Category8s");

            migrationBuilder.DropColumn(
                name: "UserCount",
                table: "Category8s");

            migrationBuilder.DropColumn(
                name: "AddToDashboard",
                table: "Category7s");

            migrationBuilder.DropColumn(
                name: "DashboardOrder",
                table: "Category7s");

            migrationBuilder.DropColumn(
                name: "OfficeCount",
                table: "Category7s");

            migrationBuilder.DropColumn(
                name: "UserCount",
                table: "Category7s");

            migrationBuilder.DropColumn(
                name: "AddToDashboard",
                table: "Category6s");

            migrationBuilder.DropColumn(
                name: "DashboardOrder",
                table: "Category6s");

            migrationBuilder.DropColumn(
                name: "OfficeCount",
                table: "Category6s");

            migrationBuilder.DropColumn(
                name: "UserCount",
                table: "Category6s");

            migrationBuilder.DropColumn(
                name: "AddToDashboard",
                table: "Category5s");

            migrationBuilder.DropColumn(
                name: "DashboardOrder",
                table: "Category5s");

            migrationBuilder.DropColumn(
                name: "OfficeCount",
                table: "Category5s");

            migrationBuilder.DropColumn(
                name: "UserCount",
                table: "Category5s");

            migrationBuilder.DropColumn(
                name: "AddToDashboard",
                table: "Category4s");

            migrationBuilder.DropColumn(
                name: "DashboardOrder",
                table: "Category4s");

            migrationBuilder.DropColumn(
                name: "OfficeCount",
                table: "Category4s");

            migrationBuilder.DropColumn(
                name: "UserCount",
                table: "Category4s");

            migrationBuilder.DropColumn(
                name: "AddToDashboard",
                table: "Category3s");

            migrationBuilder.DropColumn(
                name: "DashboardOrder",
                table: "Category3s");

            migrationBuilder.DropColumn(
                name: "OfficeCount",
                table: "Category3s");

            migrationBuilder.DropColumn(
                name: "UserCount",
                table: "Category3s");

            migrationBuilder.DropColumn(
                name: "AddToDashboard",
                table: "Category2s");

            migrationBuilder.DropColumn(
                name: "DashboardOrder",
                table: "Category2s");

            migrationBuilder.DropColumn(
                name: "OfficeCount",
                table: "Category2s");

            migrationBuilder.DropColumn(
                name: "UserCount",
                table: "Category2s");

            migrationBuilder.DropColumn(
                name: "AddToDashboard",
                table: "Category1s");

            migrationBuilder.DropColumn(
                name: "DashboardOrder",
                table: "Category1s");

            migrationBuilder.DropColumn(
                name: "OfficeCount",
                table: "Category1s");

            migrationBuilder.DropColumn(
                name: "UserCount",
                table: "Category1s");
        }
    }
}
