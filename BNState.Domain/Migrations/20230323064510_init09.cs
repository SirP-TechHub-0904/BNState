using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BNState.Domain.Data.Migrations
{
    public partial class init09 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OgLevel1s",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgLevel1s", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OgLevel2s",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OgLevel1Id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgLevel2s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OgLevel2s_OgLevel1s_OgLevel1Id",
                        column: x => x.OgLevel1Id,
                        principalTable: "OgLevel1s",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OgLevel3s",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OgLevel2Id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgLevel3s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OgLevel3s_OgLevel2s_OgLevel2Id",
                        column: x => x.OgLevel2Id,
                        principalTable: "OgLevel2s",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OgLevel4s",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OgLevel3Id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgLevel4s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OgLevel4s_OgLevel3s_OgLevel3Id",
                        column: x => x.OgLevel3Id,
                        principalTable: "OgLevel3s",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OgLevel5s",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OgLevel4Id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgLevel5s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OgLevel5s_OgLevel4s_OgLevel4Id",
                        column: x => x.OgLevel4Id,
                        principalTable: "OgLevel4s",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OgLevel6s",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OgLevel5Id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgLevel6s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OgLevel6s_OgLevel5s_OgLevel5Id",
                        column: x => x.OgLevel5Id,
                        principalTable: "OgLevel5s",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OgLevel7s",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OgLevel6Id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgLevel7s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OgLevel7s_OgLevel6s_OgLevel6Id",
                        column: x => x.OgLevel6Id,
                        principalTable: "OgLevel6s",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OgLevel8s",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OgLevel7Id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgLevel8s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OgLevel8s_OgLevel7s_OgLevel7Id",
                        column: x => x.OgLevel7Id,
                        principalTable: "OgLevel7s",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OgLevel9s",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OgLevel8Id = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OgLevel9s", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OgLevel9s_OgLevel8s_OgLevel8Id",
                        column: x => x.OgLevel8Id,
                        principalTable: "OgLevel8s",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OgAppointments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartOfAppointment = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndOfAppointment = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProfileId = table.Column<long>(type: "bigint", nullable: false),
                    ProfileId1 = table.Column<string>(type: "nvarchar(450)", nullable: true),
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
                    table.PrimaryKey("PK_OgAppointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OgAppointments_AspNetUsers_ProfileId1",
                        column: x => x.ProfileId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OgAppointments_OgLevel1s_OgLevel1Id",
                        column: x => x.OgLevel1Id,
                        principalTable: "OgLevel1s",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OgAppointments_OgLevel2s_OgLevel2Id",
                        column: x => x.OgLevel2Id,
                        principalTable: "OgLevel2s",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OgAppointments_OgLevel3s_OgLevel3Id",
                        column: x => x.OgLevel3Id,
                        principalTable: "OgLevel3s",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OgAppointments_OgLevel4s_OgLevel4Id",
                        column: x => x.OgLevel4Id,
                        principalTable: "OgLevel4s",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OgAppointments_OgLevel5s_OgLevel5Id",
                        column: x => x.OgLevel5Id,
                        principalTable: "OgLevel5s",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OgAppointments_OgLevel6s_OgLevel6Id",
                        column: x => x.OgLevel6Id,
                        principalTable: "OgLevel6s",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OgAppointments_OgLevel7s_OgLevel7Id",
                        column: x => x.OgLevel7Id,
                        principalTable: "OgLevel7s",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OgAppointments_OgLevel8s_OgLevel8Id",
                        column: x => x.OgLevel8Id,
                        principalTable: "OgLevel8s",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OgAppointments_OgLevel9s_OgLevel9Id",
                        column: x => x.OgLevel9Id,
                        principalTable: "OgLevel9s",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_OgAppointments_OgLevel1Id",
                table: "OgAppointments",
                column: "OgLevel1Id");

            migrationBuilder.CreateIndex(
                name: "IX_OgAppointments_OgLevel2Id",
                table: "OgAppointments",
                column: "OgLevel2Id");

            migrationBuilder.CreateIndex(
                name: "IX_OgAppointments_OgLevel3Id",
                table: "OgAppointments",
                column: "OgLevel3Id");

            migrationBuilder.CreateIndex(
                name: "IX_OgAppointments_OgLevel4Id",
                table: "OgAppointments",
                column: "OgLevel4Id");

            migrationBuilder.CreateIndex(
                name: "IX_OgAppointments_OgLevel5Id",
                table: "OgAppointments",
                column: "OgLevel5Id");

            migrationBuilder.CreateIndex(
                name: "IX_OgAppointments_OgLevel6Id",
                table: "OgAppointments",
                column: "OgLevel6Id");

            migrationBuilder.CreateIndex(
                name: "IX_OgAppointments_OgLevel7Id",
                table: "OgAppointments",
                column: "OgLevel7Id");

            migrationBuilder.CreateIndex(
                name: "IX_OgAppointments_OgLevel8Id",
                table: "OgAppointments",
                column: "OgLevel8Id");

            migrationBuilder.CreateIndex(
                name: "IX_OgAppointments_OgLevel9Id",
                table: "OgAppointments",
                column: "OgLevel9Id");

            migrationBuilder.CreateIndex(
                name: "IX_OgAppointments_ProfileId1",
                table: "OgAppointments",
                column: "ProfileId1");

            migrationBuilder.CreateIndex(
                name: "IX_OgLevel2s_OgLevel1Id",
                table: "OgLevel2s",
                column: "OgLevel1Id");

            migrationBuilder.CreateIndex(
                name: "IX_OgLevel3s_OgLevel2Id",
                table: "OgLevel3s",
                column: "OgLevel2Id");

            migrationBuilder.CreateIndex(
                name: "IX_OgLevel4s_OgLevel3Id",
                table: "OgLevel4s",
                column: "OgLevel3Id");

            migrationBuilder.CreateIndex(
                name: "IX_OgLevel5s_OgLevel4Id",
                table: "OgLevel5s",
                column: "OgLevel4Id");

            migrationBuilder.CreateIndex(
                name: "IX_OgLevel6s_OgLevel5Id",
                table: "OgLevel6s",
                column: "OgLevel5Id");

            migrationBuilder.CreateIndex(
                name: "IX_OgLevel7s_OgLevel6Id",
                table: "OgLevel7s",
                column: "OgLevel6Id");

            migrationBuilder.CreateIndex(
                name: "IX_OgLevel8s_OgLevel7Id",
                table: "OgLevel8s",
                column: "OgLevel7Id");

            migrationBuilder.CreateIndex(
                name: "IX_OgLevel9s_OgLevel8Id",
                table: "OgLevel9s",
                column: "OgLevel8Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OgAppointments");

            migrationBuilder.DropTable(
                name: "OgLevel9s");

            migrationBuilder.DropTable(
                name: "OgLevel8s");

            migrationBuilder.DropTable(
                name: "OgLevel7s");

            migrationBuilder.DropTable(
                name: "OgLevel6s");

            migrationBuilder.DropTable(
                name: "OgLevel5s");

            migrationBuilder.DropTable(
                name: "OgLevel4s");

            migrationBuilder.DropTable(
                name: "OgLevel3s");

            migrationBuilder.DropTable(
                name: "OgLevel2s");

            migrationBuilder.DropTable(
                name: "OgLevel1s");
        }
    }
}
