using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BNState.Domain.Data.Migrations
{
    public partial class iol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryAppointments_OgLevel1s_OgLevel1Id",
                table: "CategoryAppointments");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryAppointments_OgLevel2s_OgLevel2Id",
                table: "CategoryAppointments");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryAppointments_OgLevel3s_OgLevel3Id",
                table: "CategoryAppointments");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryAppointments_OgLevel4s_OgLevel4Id",
                table: "CategoryAppointments");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryAppointments_OgLevel5s_OgLevel5Id",
                table: "CategoryAppointments");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryAppointments_OgLevel6s_OgLevel6Id",
                table: "CategoryAppointments");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryAppointments_OgLevel7s_OgLevel7Id",
                table: "CategoryAppointments");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryAppointments_OgLevel8s_OgLevel8Id",
                table: "CategoryAppointments");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryAppointments_OgLevel9s_OgLevel9Id",
                table: "CategoryAppointments");

            migrationBuilder.DropForeignKey(
                name: "FK_OgAppointments_Category1s_Category1Id",
                table: "OgAppointments");

            migrationBuilder.DropIndex(
                name: "IX_OgAppointments_Category1Id",
                table: "OgAppointments");

            migrationBuilder.DropColumn(
                name: "Category1Id",
                table: "OgAppointments");

            migrationBuilder.RenameColumn(
                name: "OgLevel9Id",
                table: "CategoryAppointments",
                newName: "Category9Id");

            migrationBuilder.RenameColumn(
                name: "OgLevel8Id",
                table: "CategoryAppointments",
                newName: "Category8Id");

            migrationBuilder.RenameColumn(
                name: "OgLevel7Id",
                table: "CategoryAppointments",
                newName: "Category7Id");

            migrationBuilder.RenameColumn(
                name: "OgLevel6Id",
                table: "CategoryAppointments",
                newName: "Category6Id");

            migrationBuilder.RenameColumn(
                name: "OgLevel5Id",
                table: "CategoryAppointments",
                newName: "Category5Id");

            migrationBuilder.RenameColumn(
                name: "OgLevel4Id",
                table: "CategoryAppointments",
                newName: "Category4Id");

            migrationBuilder.RenameColumn(
                name: "OgLevel3Id",
                table: "CategoryAppointments",
                newName: "Category3Id");

            migrationBuilder.RenameColumn(
                name: "OgLevel2Id",
                table: "CategoryAppointments",
                newName: "Category2Id");

            migrationBuilder.RenameColumn(
                name: "OgLevel1Id",
                table: "CategoryAppointments",
                newName: "Category1Id");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryAppointments_OgLevel9Id",
                table: "CategoryAppointments",
                newName: "IX_CategoryAppointments_Category9Id");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryAppointments_OgLevel8Id",
                table: "CategoryAppointments",
                newName: "IX_CategoryAppointments_Category8Id");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryAppointments_OgLevel7Id",
                table: "CategoryAppointments",
                newName: "IX_CategoryAppointments_Category7Id");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryAppointments_OgLevel6Id",
                table: "CategoryAppointments",
                newName: "IX_CategoryAppointments_Category6Id");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryAppointments_OgLevel5Id",
                table: "CategoryAppointments",
                newName: "IX_CategoryAppointments_Category5Id");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryAppointments_OgLevel4Id",
                table: "CategoryAppointments",
                newName: "IX_CategoryAppointments_Category4Id");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryAppointments_OgLevel3Id",
                table: "CategoryAppointments",
                newName: "IX_CategoryAppointments_Category3Id");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryAppointments_OgLevel2Id",
                table: "CategoryAppointments",
                newName: "IX_CategoryAppointments_Category2Id");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryAppointments_OgLevel1Id",
                table: "CategoryAppointments",
                newName: "IX_CategoryAppointments_Category1Id");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Category9s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Category9s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Category9s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumbers",
                table: "Category9s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "ShowAddress",
                table: "Category9s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ShowCode",
                table: "Category9s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ShowEmail",
                table: "Category9s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ShowPhoneNumbers",
                table: "Category9s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ShowWebsite",
                table: "Category9s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Website",
                table: "Category9s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Category8s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Category8s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Category8s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumbers",
                table: "Category8s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "ShowAddress",
                table: "Category8s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ShowCode",
                table: "Category8s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ShowEmail",
                table: "Category8s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ShowPhoneNumbers",
                table: "Category8s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ShowWebsite",
                table: "Category8s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Website",
                table: "Category8s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Category7s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Category7s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Category7s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumbers",
                table: "Category7s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "ShowAddress",
                table: "Category7s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ShowCode",
                table: "Category7s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ShowEmail",
                table: "Category7s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ShowPhoneNumbers",
                table: "Category7s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ShowWebsite",
                table: "Category7s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Website",
                table: "Category7s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Category6s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Category6s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Category6s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumbers",
                table: "Category6s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "ShowAddress",
                table: "Category6s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ShowCode",
                table: "Category6s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ShowEmail",
                table: "Category6s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ShowPhoneNumbers",
                table: "Category6s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ShowWebsite",
                table: "Category6s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Website",
                table: "Category6s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Category5s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Category5s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Category5s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumbers",
                table: "Category5s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "ShowAddress",
                table: "Category5s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ShowCode",
                table: "Category5s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ShowEmail",
                table: "Category5s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ShowPhoneNumbers",
                table: "Category5s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ShowWebsite",
                table: "Category5s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Website",
                table: "Category5s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Category4s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Category4s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Category4s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumbers",
                table: "Category4s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "ShowAddress",
                table: "Category4s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ShowCode",
                table: "Category4s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ShowEmail",
                table: "Category4s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ShowPhoneNumbers",
                table: "Category4s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ShowWebsite",
                table: "Category4s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Website",
                table: "Category4s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Category3s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Category3s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Category3s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumbers",
                table: "Category3s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "ShowAddress",
                table: "Category3s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ShowCode",
                table: "Category3s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ShowEmail",
                table: "Category3s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ShowPhoneNumbers",
                table: "Category3s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ShowWebsite",
                table: "Category3s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Website",
                table: "Category3s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Category2s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Category2s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Category2s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumbers",
                table: "Category2s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "ShowAddress",
                table: "Category2s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ShowCode",
                table: "Category2s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ShowEmail",
                table: "Category2s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ShowPhoneNumbers",
                table: "Category2s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ShowWebsite",
                table: "Category2s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Website",
                table: "Category2s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Category1s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Category1s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Category1s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "Category1s",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumbers",
                table: "Category1s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "ShowAddress",
                table: "Category1s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ShowCode",
                table: "Category1s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ShowEmail",
                table: "Category1s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ShowPhoneNumbers",
                table: "Category1s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "ShowWebsite",
                table: "Category1s",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Website",
                table: "Category1s",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryAppointments_Category1s_Category1Id",
                table: "CategoryAppointments",
                column: "Category1Id",
                principalTable: "Category1s",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryAppointments_Category2s_Category2Id",
                table: "CategoryAppointments",
                column: "Category2Id",
                principalTable: "Category2s",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryAppointments_Category3s_Category3Id",
                table: "CategoryAppointments",
                column: "Category3Id",
                principalTable: "Category3s",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryAppointments_Category4s_Category4Id",
                table: "CategoryAppointments",
                column: "Category4Id",
                principalTable: "Category4s",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryAppointments_Category5s_Category5Id",
                table: "CategoryAppointments",
                column: "Category5Id",
                principalTable: "Category5s",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryAppointments_Category6s_Category6Id",
                table: "CategoryAppointments",
                column: "Category6Id",
                principalTable: "Category6s",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryAppointments_Category7s_Category7Id",
                table: "CategoryAppointments",
                column: "Category7Id",
                principalTable: "Category7s",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryAppointments_Category8s_Category8Id",
                table: "CategoryAppointments",
                column: "Category8Id",
                principalTable: "Category8s",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryAppointments_Category9s_Category9Id",
                table: "CategoryAppointments",
                column: "Category9Id",
                principalTable: "Category9s",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CategoryAppointments_Category1s_Category1Id",
                table: "CategoryAppointments");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryAppointments_Category2s_Category2Id",
                table: "CategoryAppointments");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryAppointments_Category3s_Category3Id",
                table: "CategoryAppointments");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryAppointments_Category4s_Category4Id",
                table: "CategoryAppointments");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryAppointments_Category5s_Category5Id",
                table: "CategoryAppointments");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryAppointments_Category6s_Category6Id",
                table: "CategoryAppointments");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryAppointments_Category7s_Category7Id",
                table: "CategoryAppointments");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryAppointments_Category8s_Category8Id",
                table: "CategoryAppointments");

            migrationBuilder.DropForeignKey(
                name: "FK_CategoryAppointments_Category9s_Category9Id",
                table: "CategoryAppointments");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Category9s");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Category9s");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Category9s");

            migrationBuilder.DropColumn(
                name: "PhoneNumbers",
                table: "Category9s");

            migrationBuilder.DropColumn(
                name: "ShowAddress",
                table: "Category9s");

            migrationBuilder.DropColumn(
                name: "ShowCode",
                table: "Category9s");

            migrationBuilder.DropColumn(
                name: "ShowEmail",
                table: "Category9s");

            migrationBuilder.DropColumn(
                name: "ShowPhoneNumbers",
                table: "Category9s");

            migrationBuilder.DropColumn(
                name: "ShowWebsite",
                table: "Category9s");

            migrationBuilder.DropColumn(
                name: "Website",
                table: "Category9s");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Category8s");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Category8s");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Category8s");

            migrationBuilder.DropColumn(
                name: "PhoneNumbers",
                table: "Category8s");

            migrationBuilder.DropColumn(
                name: "ShowAddress",
                table: "Category8s");

            migrationBuilder.DropColumn(
                name: "ShowCode",
                table: "Category8s");

            migrationBuilder.DropColumn(
                name: "ShowEmail",
                table: "Category8s");

            migrationBuilder.DropColumn(
                name: "ShowPhoneNumbers",
                table: "Category8s");

            migrationBuilder.DropColumn(
                name: "ShowWebsite",
                table: "Category8s");

            migrationBuilder.DropColumn(
                name: "Website",
                table: "Category8s");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Category7s");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Category7s");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Category7s");

            migrationBuilder.DropColumn(
                name: "PhoneNumbers",
                table: "Category7s");

            migrationBuilder.DropColumn(
                name: "ShowAddress",
                table: "Category7s");

            migrationBuilder.DropColumn(
                name: "ShowCode",
                table: "Category7s");

            migrationBuilder.DropColumn(
                name: "ShowEmail",
                table: "Category7s");

            migrationBuilder.DropColumn(
                name: "ShowPhoneNumbers",
                table: "Category7s");

            migrationBuilder.DropColumn(
                name: "ShowWebsite",
                table: "Category7s");

            migrationBuilder.DropColumn(
                name: "Website",
                table: "Category7s");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Category6s");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Category6s");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Category6s");

            migrationBuilder.DropColumn(
                name: "PhoneNumbers",
                table: "Category6s");

            migrationBuilder.DropColumn(
                name: "ShowAddress",
                table: "Category6s");

            migrationBuilder.DropColumn(
                name: "ShowCode",
                table: "Category6s");

            migrationBuilder.DropColumn(
                name: "ShowEmail",
                table: "Category6s");

            migrationBuilder.DropColumn(
                name: "ShowPhoneNumbers",
                table: "Category6s");

            migrationBuilder.DropColumn(
                name: "ShowWebsite",
                table: "Category6s");

            migrationBuilder.DropColumn(
                name: "Website",
                table: "Category6s");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Category5s");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Category5s");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Category5s");

            migrationBuilder.DropColumn(
                name: "PhoneNumbers",
                table: "Category5s");

            migrationBuilder.DropColumn(
                name: "ShowAddress",
                table: "Category5s");

            migrationBuilder.DropColumn(
                name: "ShowCode",
                table: "Category5s");

            migrationBuilder.DropColumn(
                name: "ShowEmail",
                table: "Category5s");

            migrationBuilder.DropColumn(
                name: "ShowPhoneNumbers",
                table: "Category5s");

            migrationBuilder.DropColumn(
                name: "ShowWebsite",
                table: "Category5s");

            migrationBuilder.DropColumn(
                name: "Website",
                table: "Category5s");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Category4s");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Category4s");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Category4s");

            migrationBuilder.DropColumn(
                name: "PhoneNumbers",
                table: "Category4s");

            migrationBuilder.DropColumn(
                name: "ShowAddress",
                table: "Category4s");

            migrationBuilder.DropColumn(
                name: "ShowCode",
                table: "Category4s");

            migrationBuilder.DropColumn(
                name: "ShowEmail",
                table: "Category4s");

            migrationBuilder.DropColumn(
                name: "ShowPhoneNumbers",
                table: "Category4s");

            migrationBuilder.DropColumn(
                name: "ShowWebsite",
                table: "Category4s");

            migrationBuilder.DropColumn(
                name: "Website",
                table: "Category4s");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Category3s");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Category3s");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Category3s");

            migrationBuilder.DropColumn(
                name: "PhoneNumbers",
                table: "Category3s");

            migrationBuilder.DropColumn(
                name: "ShowAddress",
                table: "Category3s");

            migrationBuilder.DropColumn(
                name: "ShowCode",
                table: "Category3s");

            migrationBuilder.DropColumn(
                name: "ShowEmail",
                table: "Category3s");

            migrationBuilder.DropColumn(
                name: "ShowPhoneNumbers",
                table: "Category3s");

            migrationBuilder.DropColumn(
                name: "ShowWebsite",
                table: "Category3s");

            migrationBuilder.DropColumn(
                name: "Website",
                table: "Category3s");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Category2s");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Category2s");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Category2s");

            migrationBuilder.DropColumn(
                name: "PhoneNumbers",
                table: "Category2s");

            migrationBuilder.DropColumn(
                name: "ShowAddress",
                table: "Category2s");

            migrationBuilder.DropColumn(
                name: "ShowCode",
                table: "Category2s");

            migrationBuilder.DropColumn(
                name: "ShowEmail",
                table: "Category2s");

            migrationBuilder.DropColumn(
                name: "ShowPhoneNumbers",
                table: "Category2s");

            migrationBuilder.DropColumn(
                name: "ShowWebsite",
                table: "Category2s");

            migrationBuilder.DropColumn(
                name: "Website",
                table: "Category2s");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Category1s");

            migrationBuilder.DropColumn(
                name: "Code",
                table: "Category1s");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Category1s");

            migrationBuilder.DropColumn(
                name: "Order",
                table: "Category1s");

            migrationBuilder.DropColumn(
                name: "PhoneNumbers",
                table: "Category1s");

            migrationBuilder.DropColumn(
                name: "ShowAddress",
                table: "Category1s");

            migrationBuilder.DropColumn(
                name: "ShowCode",
                table: "Category1s");

            migrationBuilder.DropColumn(
                name: "ShowEmail",
                table: "Category1s");

            migrationBuilder.DropColumn(
                name: "ShowPhoneNumbers",
                table: "Category1s");

            migrationBuilder.DropColumn(
                name: "ShowWebsite",
                table: "Category1s");

            migrationBuilder.DropColumn(
                name: "Website",
                table: "Category1s");

            migrationBuilder.RenameColumn(
                name: "Category9Id",
                table: "CategoryAppointments",
                newName: "OgLevel9Id");

            migrationBuilder.RenameColumn(
                name: "Category8Id",
                table: "CategoryAppointments",
                newName: "OgLevel8Id");

            migrationBuilder.RenameColumn(
                name: "Category7Id",
                table: "CategoryAppointments",
                newName: "OgLevel7Id");

            migrationBuilder.RenameColumn(
                name: "Category6Id",
                table: "CategoryAppointments",
                newName: "OgLevel6Id");

            migrationBuilder.RenameColumn(
                name: "Category5Id",
                table: "CategoryAppointments",
                newName: "OgLevel5Id");

            migrationBuilder.RenameColumn(
                name: "Category4Id",
                table: "CategoryAppointments",
                newName: "OgLevel4Id");

            migrationBuilder.RenameColumn(
                name: "Category3Id",
                table: "CategoryAppointments",
                newName: "OgLevel3Id");

            migrationBuilder.RenameColumn(
                name: "Category2Id",
                table: "CategoryAppointments",
                newName: "OgLevel2Id");

            migrationBuilder.RenameColumn(
                name: "Category1Id",
                table: "CategoryAppointments",
                newName: "OgLevel1Id");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryAppointments_Category9Id",
                table: "CategoryAppointments",
                newName: "IX_CategoryAppointments_OgLevel9Id");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryAppointments_Category8Id",
                table: "CategoryAppointments",
                newName: "IX_CategoryAppointments_OgLevel8Id");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryAppointments_Category7Id",
                table: "CategoryAppointments",
                newName: "IX_CategoryAppointments_OgLevel7Id");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryAppointments_Category6Id",
                table: "CategoryAppointments",
                newName: "IX_CategoryAppointments_OgLevel6Id");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryAppointments_Category5Id",
                table: "CategoryAppointments",
                newName: "IX_CategoryAppointments_OgLevel5Id");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryAppointments_Category4Id",
                table: "CategoryAppointments",
                newName: "IX_CategoryAppointments_OgLevel4Id");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryAppointments_Category3Id",
                table: "CategoryAppointments",
                newName: "IX_CategoryAppointments_OgLevel3Id");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryAppointments_Category2Id",
                table: "CategoryAppointments",
                newName: "IX_CategoryAppointments_OgLevel2Id");

            migrationBuilder.RenameIndex(
                name: "IX_CategoryAppointments_Category1Id",
                table: "CategoryAppointments",
                newName: "IX_CategoryAppointments_OgLevel1Id");

            migrationBuilder.AddColumn<long>(
                name: "Category1Id",
                table: "OgAppointments",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OgAppointments_Category1Id",
                table: "OgAppointments",
                column: "Category1Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryAppointments_OgLevel1s_OgLevel1Id",
                table: "CategoryAppointments",
                column: "OgLevel1Id",
                principalTable: "OgLevel1s",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryAppointments_OgLevel2s_OgLevel2Id",
                table: "CategoryAppointments",
                column: "OgLevel2Id",
                principalTable: "OgLevel2s",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryAppointments_OgLevel3s_OgLevel3Id",
                table: "CategoryAppointments",
                column: "OgLevel3Id",
                principalTable: "OgLevel3s",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryAppointments_OgLevel4s_OgLevel4Id",
                table: "CategoryAppointments",
                column: "OgLevel4Id",
                principalTable: "OgLevel4s",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryAppointments_OgLevel5s_OgLevel5Id",
                table: "CategoryAppointments",
                column: "OgLevel5Id",
                principalTable: "OgLevel5s",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryAppointments_OgLevel6s_OgLevel6Id",
                table: "CategoryAppointments",
                column: "OgLevel6Id",
                principalTable: "OgLevel6s",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryAppointments_OgLevel7s_OgLevel7Id",
                table: "CategoryAppointments",
                column: "OgLevel7Id",
                principalTable: "OgLevel7s",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryAppointments_OgLevel8s_OgLevel8Id",
                table: "CategoryAppointments",
                column: "OgLevel8Id",
                principalTable: "OgLevel8s",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CategoryAppointments_OgLevel9s_OgLevel9Id",
                table: "CategoryAppointments",
                column: "OgLevel9Id",
                principalTable: "OgLevel9s",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OgAppointments_Category1s_Category1Id",
                table: "OgAppointments",
                column: "Category1Id",
                principalTable: "Category1s",
                principalColumn: "Id");
        }
    }
}
