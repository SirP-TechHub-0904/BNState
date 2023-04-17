using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BNState.Domain.Data.Migrations
{
    public partial class cat : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "Category1Id",
                table: "OgAppointments",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Category2Id",
                table: "OgAppointments",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Category3Id",
                table: "OgAppointments",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Category4Id",
                table: "OgAppointments",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Category5Id",
                table: "OgAppointments",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Category6Id",
                table: "OgAppointments",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Category7Id",
                table: "OgAppointments",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Category8Id",
                table: "OgAppointments",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "Category9Id",
                table: "OgAppointments",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Category1s",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category1s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoryAppointments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartOfAppointment = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndOfAppointment = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    ProfileId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OgLevel1Id = table.Column<long>(type: "bigint", nullable: true),
                    OgLevel2Id = table.Column<long>(type: "bigint", nullable: true),
                    OgLevel3Id = table.Column<long>(type: "bigint", nullable: true),
                    OgLevel4Id = table.Column<long>(type: "bigint", nullable: true),
                    OgLevel5Id = table.Column<long>(type: "bigint", nullable: true),
                    OgLevel6Id = table.Column<long>(type: "bigint", nullable: true),
                    OgLevel7Id = table.Column<long>(type: "bigint", nullable: true),
                    OgLevel8Id = table.Column<long>(type: "bigint", nullable: true),
                    OgLevel9Id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryAppointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CategoryAppointments_AspNetUsers_ProfileId",
                        column: x => x.ProfileId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryAppointments_OgLevel1s_OgLevel1Id",
                        column: x => x.OgLevel1Id,
                        principalTable: "OgLevel1s",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CategoryAppointments_OgLevel2s_OgLevel2Id",
                        column: x => x.OgLevel2Id,
                        principalTable: "OgLevel2s",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CategoryAppointments_OgLevel3s_OgLevel3Id",
                        column: x => x.OgLevel3Id,
                        principalTable: "OgLevel3s",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CategoryAppointments_OgLevel4s_OgLevel4Id",
                        column: x => x.OgLevel4Id,
                        principalTable: "OgLevel4s",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CategoryAppointments_OgLevel5s_OgLevel5Id",
                        column: x => x.OgLevel5Id,
                        principalTable: "OgLevel5s",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CategoryAppointments_OgLevel6s_OgLevel6Id",
                        column: x => x.OgLevel6Id,
                        principalTable: "OgLevel6s",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CategoryAppointments_OgLevel7s_OgLevel7Id",
                        column: x => x.OgLevel7Id,
                        principalTable: "OgLevel7s",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CategoryAppointments_OgLevel8s_OgLevel8Id",
                        column: x => x.OgLevel8Id,
                        principalTable: "OgLevel8s",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CategoryAppointments_OgLevel9s_OgLevel9Id",
                        column: x => x.OgLevel9Id,
                        principalTable: "OgLevel9s",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Category2s",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category1Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category2s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Category2s_Category1s_Category1Id",
                        column: x => x.Category1Id,
                        principalTable: "Category1s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Category3s",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category2Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category3s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Category3s_Category2s_Category2Id",
                        column: x => x.Category2Id,
                        principalTable: "Category2s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Category4s",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category3Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category4s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Category4s_Category3s_Category3Id",
                        column: x => x.Category3Id,
                        principalTable: "Category3s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Category5s",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category4Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category5s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Category5s_Category4s_Category4Id",
                        column: x => x.Category4Id,
                        principalTable: "Category4s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Category6s",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category5Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category6s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Category6s_Category5s_Category5Id",
                        column: x => x.Category5Id,
                        principalTable: "Category5s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Category7s",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category6Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category7s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Category7s_Category6s_Category6Id",
                        column: x => x.Category6Id,
                        principalTable: "Category6s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Category8s",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category7Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category8s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Category8s_Category7s_Category7Id",
                        column: x => x.Category7Id,
                        principalTable: "Category7s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Category9s",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category8Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category9s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Category9s_Category8s_Category8Id",
                        column: x => x.Category8Id,
                        principalTable: "Category8s",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OgAppointments_Category1Id",
                table: "OgAppointments",
                column: "Category1Id");

            migrationBuilder.CreateIndex(
                name: "IX_OgAppointments_Category2Id",
                table: "OgAppointments",
                column: "Category2Id");

            migrationBuilder.CreateIndex(
                name: "IX_OgAppointments_Category3Id",
                table: "OgAppointments",
                column: "Category3Id");

            migrationBuilder.CreateIndex(
                name: "IX_OgAppointments_Category4Id",
                table: "OgAppointments",
                column: "Category4Id");

            migrationBuilder.CreateIndex(
                name: "IX_OgAppointments_Category5Id",
                table: "OgAppointments",
                column: "Category5Id");

            migrationBuilder.CreateIndex(
                name: "IX_OgAppointments_Category6Id",
                table: "OgAppointments",
                column: "Category6Id");

            migrationBuilder.CreateIndex(
                name: "IX_OgAppointments_Category7Id",
                table: "OgAppointments",
                column: "Category7Id");

            migrationBuilder.CreateIndex(
                name: "IX_OgAppointments_Category8Id",
                table: "OgAppointments",
                column: "Category8Id");

            migrationBuilder.CreateIndex(
                name: "IX_OgAppointments_Category9Id",
                table: "OgAppointments",
                column: "Category9Id");

            migrationBuilder.CreateIndex(
                name: "IX_Category2s_Category1Id",
                table: "Category2s",
                column: "Category1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Category3s_Category2Id",
                table: "Category3s",
                column: "Category2Id");

            migrationBuilder.CreateIndex(
                name: "IX_Category4s_Category3Id",
                table: "Category4s",
                column: "Category3Id");

            migrationBuilder.CreateIndex(
                name: "IX_Category5s_Category4Id",
                table: "Category5s",
                column: "Category4Id");

            migrationBuilder.CreateIndex(
                name: "IX_Category6s_Category5Id",
                table: "Category6s",
                column: "Category5Id");

            migrationBuilder.CreateIndex(
                name: "IX_Category7s_Category6Id",
                table: "Category7s",
                column: "Category6Id");

            migrationBuilder.CreateIndex(
                name: "IX_Category8s_Category7Id",
                table: "Category8s",
                column: "Category7Id");

            migrationBuilder.CreateIndex(
                name: "IX_Category9s_Category8Id",
                table: "Category9s",
                column: "Category8Id");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryAppointments_OgLevel1Id",
                table: "CategoryAppointments",
                column: "OgLevel1Id");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryAppointments_OgLevel2Id",
                table: "CategoryAppointments",
                column: "OgLevel2Id");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryAppointments_OgLevel3Id",
                table: "CategoryAppointments",
                column: "OgLevel3Id");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryAppointments_OgLevel4Id",
                table: "CategoryAppointments",
                column: "OgLevel4Id");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryAppointments_OgLevel5Id",
                table: "CategoryAppointments",
                column: "OgLevel5Id");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryAppointments_OgLevel6Id",
                table: "CategoryAppointments",
                column: "OgLevel6Id");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryAppointments_OgLevel7Id",
                table: "CategoryAppointments",
                column: "OgLevel7Id");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryAppointments_OgLevel8Id",
                table: "CategoryAppointments",
                column: "OgLevel8Id");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryAppointments_OgLevel9Id",
                table: "CategoryAppointments",
                column: "OgLevel9Id");

            migrationBuilder.CreateIndex(
                name: "IX_CategoryAppointments_ProfileId",
                table: "CategoryAppointments",
                column: "ProfileId");

            migrationBuilder.AddForeignKey(
                name: "FK_OgAppointments_Category1s_Category1Id",
                table: "OgAppointments",
                column: "Category1Id",
                principalTable: "Category1s",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OgAppointments_Category2s_Category2Id",
                table: "OgAppointments",
                column: "Category2Id",
                principalTable: "Category2s",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OgAppointments_Category3s_Category3Id",
                table: "OgAppointments",
                column: "Category3Id",
                principalTable: "Category3s",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OgAppointments_Category4s_Category4Id",
                table: "OgAppointments",
                column: "Category4Id",
                principalTable: "Category4s",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OgAppointments_Category5s_Category5Id",
                table: "OgAppointments",
                column: "Category5Id",
                principalTable: "Category5s",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OgAppointments_Category6s_Category6Id",
                table: "OgAppointments",
                column: "Category6Id",
                principalTable: "Category6s",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OgAppointments_Category7s_Category7Id",
                table: "OgAppointments",
                column: "Category7Id",
                principalTable: "Category7s",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OgAppointments_Category8s_Category8Id",
                table: "OgAppointments",
                column: "Category8Id",
                principalTable: "Category8s",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OgAppointments_Category9s_Category9Id",
                table: "OgAppointments",
                column: "Category9Id",
                principalTable: "Category9s",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OgAppointments_Category1s_Category1Id",
                table: "OgAppointments");

            migrationBuilder.DropForeignKey(
                name: "FK_OgAppointments_Category2s_Category2Id",
                table: "OgAppointments");

            migrationBuilder.DropForeignKey(
                name: "FK_OgAppointments_Category3s_Category3Id",
                table: "OgAppointments");

            migrationBuilder.DropForeignKey(
                name: "FK_OgAppointments_Category4s_Category4Id",
                table: "OgAppointments");

            migrationBuilder.DropForeignKey(
                name: "FK_OgAppointments_Category5s_Category5Id",
                table: "OgAppointments");

            migrationBuilder.DropForeignKey(
                name: "FK_OgAppointments_Category6s_Category6Id",
                table: "OgAppointments");

            migrationBuilder.DropForeignKey(
                name: "FK_OgAppointments_Category7s_Category7Id",
                table: "OgAppointments");

            migrationBuilder.DropForeignKey(
                name: "FK_OgAppointments_Category8s_Category8Id",
                table: "OgAppointments");

            migrationBuilder.DropForeignKey(
                name: "FK_OgAppointments_Category9s_Category9Id",
                table: "OgAppointments");

            migrationBuilder.DropTable(
                name: "Category9s");

            migrationBuilder.DropTable(
                name: "CategoryAppointments");

            migrationBuilder.DropTable(
                name: "Category8s");

            migrationBuilder.DropTable(
                name: "Category7s");

            migrationBuilder.DropTable(
                name: "Category6s");

            migrationBuilder.DropTable(
                name: "Category5s");

            migrationBuilder.DropTable(
                name: "Category4s");

            migrationBuilder.DropTable(
                name: "Category3s");

            migrationBuilder.DropTable(
                name: "Category2s");

            migrationBuilder.DropTable(
                name: "Category1s");

            migrationBuilder.DropIndex(
                name: "IX_OgAppointments_Category1Id",
                table: "OgAppointments");

            migrationBuilder.DropIndex(
                name: "IX_OgAppointments_Category2Id",
                table: "OgAppointments");

            migrationBuilder.DropIndex(
                name: "IX_OgAppointments_Category3Id",
                table: "OgAppointments");

            migrationBuilder.DropIndex(
                name: "IX_OgAppointments_Category4Id",
                table: "OgAppointments");

            migrationBuilder.DropIndex(
                name: "IX_OgAppointments_Category5Id",
                table: "OgAppointments");

            migrationBuilder.DropIndex(
                name: "IX_OgAppointments_Category6Id",
                table: "OgAppointments");

            migrationBuilder.DropIndex(
                name: "IX_OgAppointments_Category7Id",
                table: "OgAppointments");

            migrationBuilder.DropIndex(
                name: "IX_OgAppointments_Category8Id",
                table: "OgAppointments");

            migrationBuilder.DropIndex(
                name: "IX_OgAppointments_Category9Id",
                table: "OgAppointments");

            migrationBuilder.DropColumn(
                name: "Category1Id",
                table: "OgAppointments");

            migrationBuilder.DropColumn(
                name: "Category2Id",
                table: "OgAppointments");

            migrationBuilder.DropColumn(
                name: "Category3Id",
                table: "OgAppointments");

            migrationBuilder.DropColumn(
                name: "Category4Id",
                table: "OgAppointments");

            migrationBuilder.DropColumn(
                name: "Category5Id",
                table: "OgAppointments");

            migrationBuilder.DropColumn(
                name: "Category6Id",
                table: "OgAppointments");

            migrationBuilder.DropColumn(
                name: "Category7Id",
                table: "OgAppointments");

            migrationBuilder.DropColumn(
                name: "Category8Id",
                table: "OgAppointments");

            migrationBuilder.DropColumn(
                name: "Category9Id",
                table: "OgAppointments");
        }
    }
}
