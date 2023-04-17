using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BNState.Domain.Data.Migrations
{
    public partial class DO : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OgAppointments_AspNetUsers_ProfileId1",
                table: "OgAppointments");

            migrationBuilder.DropIndex(
                name: "IX_OgAppointments_ProfileId1",
                table: "OgAppointments");

            migrationBuilder.DropColumn(
                name: "ProfileId1",
                table: "OgAppointments");

            migrationBuilder.AlterColumn<string>(
                name: "ProfileId",
                table: "OgAppointments",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.CreateIndex(
                name: "IX_OgAppointments_ProfileId",
                table: "OgAppointments",
                column: "ProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_OgAppointments_AspNetUsers_ProfileId",
                table: "OgAppointments",
                column: "ProfileId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OgAppointments_AspNetUsers_ProfileId",
                table: "OgAppointments");

            migrationBuilder.DropIndex(
                name: "IX_OgAppointments_ProfileId",
                table: "OgAppointments");

            migrationBuilder.AlterColumn<long>(
                name: "ProfileId",
                table: "OgAppointments",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "ProfileId1",
                table: "OgAppointments",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_OgAppointments_ProfileId1",
                table: "OgAppointments",
                column: "ProfileId1");

            migrationBuilder.AddForeignKey(
                name: "FK_OgAppointments_AspNetUsers_ProfileId1",
                table: "OgAppointments",
                column: "ProfileId1",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
