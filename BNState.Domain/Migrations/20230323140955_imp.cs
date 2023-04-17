using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BNState.Domain.Data.Migrations
{
    public partial class imp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OgLevel2s_OgLevel1s_OgLevel1Id",
                table: "OgLevel2s");

            migrationBuilder.DropForeignKey(
                name: "FK_OgLevel3s_OgLevel2s_OgLevel2Id",
                table: "OgLevel3s");

            migrationBuilder.DropForeignKey(
                name: "FK_OgLevel4s_OgLevel3s_OgLevel3Id",
                table: "OgLevel4s");

            migrationBuilder.DropForeignKey(
                name: "FK_OgLevel5s_OgLevel4s_OgLevel4Id",
                table: "OgLevel5s");

            migrationBuilder.DropForeignKey(
                name: "FK_OgLevel6s_OgLevel5s_OgLevel5Id",
                table: "OgLevel6s");

            migrationBuilder.DropForeignKey(
                name: "FK_OgLevel7s_OgLevel6s_OgLevel6Id",
                table: "OgLevel7s");

            migrationBuilder.DropForeignKey(
                name: "FK_OgLevel8s_OgLevel7s_OgLevel7Id",
                table: "OgLevel8s");

            migrationBuilder.DropForeignKey(
                name: "FK_OgLevel9s_OgLevel8s_OgLevel8Id",
                table: "OgLevel9s");

            migrationBuilder.AlterColumn<long>(
                name: "OgLevel8Id",
                table: "OgLevel9s",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "OgLevel7Id",
                table: "OgLevel8s",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "OgLevel6Id",
                table: "OgLevel7s",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "OgLevel5Id",
                table: "OgLevel6s",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "OgLevel4Id",
                table: "OgLevel5s",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "OgLevel3Id",
                table: "OgLevel4s",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "OgLevel2Id",
                table: "OgLevel3s",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "OgLevel1Id",
                table: "OgLevel2s",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_OgLevel2s_OgLevel1s_OgLevel1Id",
                table: "OgLevel2s",
                column: "OgLevel1Id",
                principalTable: "OgLevel1s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OgLevel3s_OgLevel2s_OgLevel2Id",
                table: "OgLevel3s",
                column: "OgLevel2Id",
                principalTable: "OgLevel2s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OgLevel4s_OgLevel3s_OgLevel3Id",
                table: "OgLevel4s",
                column: "OgLevel3Id",
                principalTable: "OgLevel3s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OgLevel5s_OgLevel4s_OgLevel4Id",
                table: "OgLevel5s",
                column: "OgLevel4Id",
                principalTable: "OgLevel4s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OgLevel6s_OgLevel5s_OgLevel5Id",
                table: "OgLevel6s",
                column: "OgLevel5Id",
                principalTable: "OgLevel5s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OgLevel7s_OgLevel6s_OgLevel6Id",
                table: "OgLevel7s",
                column: "OgLevel6Id",
                principalTable: "OgLevel6s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OgLevel8s_OgLevel7s_OgLevel7Id",
                table: "OgLevel8s",
                column: "OgLevel7Id",
                principalTable: "OgLevel7s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OgLevel9s_OgLevel8s_OgLevel8Id",
                table: "OgLevel9s",
                column: "OgLevel8Id",
                principalTable: "OgLevel8s",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OgLevel2s_OgLevel1s_OgLevel1Id",
                table: "OgLevel2s");

            migrationBuilder.DropForeignKey(
                name: "FK_OgLevel3s_OgLevel2s_OgLevel2Id",
                table: "OgLevel3s");

            migrationBuilder.DropForeignKey(
                name: "FK_OgLevel4s_OgLevel3s_OgLevel3Id",
                table: "OgLevel4s");

            migrationBuilder.DropForeignKey(
                name: "FK_OgLevel5s_OgLevel4s_OgLevel4Id",
                table: "OgLevel5s");

            migrationBuilder.DropForeignKey(
                name: "FK_OgLevel6s_OgLevel5s_OgLevel5Id",
                table: "OgLevel6s");

            migrationBuilder.DropForeignKey(
                name: "FK_OgLevel7s_OgLevel6s_OgLevel6Id",
                table: "OgLevel7s");

            migrationBuilder.DropForeignKey(
                name: "FK_OgLevel8s_OgLevel7s_OgLevel7Id",
                table: "OgLevel8s");

            migrationBuilder.DropForeignKey(
                name: "FK_OgLevel9s_OgLevel8s_OgLevel8Id",
                table: "OgLevel9s");

            migrationBuilder.AlterColumn<long>(
                name: "OgLevel8Id",
                table: "OgLevel9s",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "OgLevel7Id",
                table: "OgLevel8s",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "OgLevel6Id",
                table: "OgLevel7s",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "OgLevel5Id",
                table: "OgLevel6s",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "OgLevel4Id",
                table: "OgLevel5s",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "OgLevel3Id",
                table: "OgLevel4s",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "OgLevel2Id",
                table: "OgLevel3s",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "OgLevel1Id",
                table: "OgLevel2s",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AddForeignKey(
                name: "FK_OgLevel2s_OgLevel1s_OgLevel1Id",
                table: "OgLevel2s",
                column: "OgLevel1Id",
                principalTable: "OgLevel1s",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OgLevel3s_OgLevel2s_OgLevel2Id",
                table: "OgLevel3s",
                column: "OgLevel2Id",
                principalTable: "OgLevel2s",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OgLevel4s_OgLevel3s_OgLevel3Id",
                table: "OgLevel4s",
                column: "OgLevel3Id",
                principalTable: "OgLevel3s",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OgLevel5s_OgLevel4s_OgLevel4Id",
                table: "OgLevel5s",
                column: "OgLevel4Id",
                principalTable: "OgLevel4s",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OgLevel6s_OgLevel5s_OgLevel5Id",
                table: "OgLevel6s",
                column: "OgLevel5Id",
                principalTable: "OgLevel5s",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OgLevel7s_OgLevel6s_OgLevel6Id",
                table: "OgLevel7s",
                column: "OgLevel6Id",
                principalTable: "OgLevel6s",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OgLevel8s_OgLevel7s_OgLevel7Id",
                table: "OgLevel8s",
                column: "OgLevel7Id",
                principalTable: "OgLevel7s",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OgLevel9s_OgLevel8s_OgLevel8Id",
                table: "OgLevel9s",
                column: "OgLevel8Id",
                principalTable: "OgLevel8s",
                principalColumn: "Id");
        }
    }
}
