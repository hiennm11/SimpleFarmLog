using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SimpleFarmLog.Migrations
{
    public partial class InitDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BoarHerds",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    InitDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2020, 12, 10, 20, 7, 58, 756, DateTimeKind.Local).AddTicks(6187)),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BoarHerds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fodders",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<double>(type: "float", nullable: false, defaultValue: 0.0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fodders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ingredients",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<double>(type: "float", nullable: false, defaultValue: 0.0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ingredients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Medicines",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amount = table.Column<double>(type: "float", nullable: false, defaultValue: 0.0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicines", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Boars",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Color = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    HerdId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2020, 12, 10, 20, 7, 58, 748, DateTimeKind.Local).AddTicks(5337)),
                    Weight = table.Column<double>(type: "float", nullable: true),
                    Gender = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Boars_BoarHerds_HerdId",
                        column: x => x.HerdId,
                        principalTable: "BoarHerds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SeedLogs",
                columns: table => new
                {
                    HerdId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FodderId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SeedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2020, 12, 10, 20, 7, 58, 770, DateTimeKind.Local).AddTicks(9925)),
                    Amount = table.Column<double>(type: "float", nullable: false, defaultValue: 0.0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SeedLogs", x => new { x.HerdId, x.FodderId });
                    table.ForeignKey(
                        name: "FK_SeedLogs_BoarHerds_HerdId",
                        column: x => x.HerdId,
                        principalTable: "BoarHerds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SeedLogs_Fodders_FodderId",
                        column: x => x.FodderId,
                        principalTable: "Fodders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MixLogs",
                columns: table => new
                {
                    IngredientId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FodderId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IngredientAmount = table.Column<double>(type: "float", nullable: false, defaultValue: 0.0),
                    MixDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2020, 12, 10, 20, 7, 58, 769, DateTimeKind.Local).AddTicks(1187))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MixLogs", x => new { x.FodderId, x.IngredientId });
                    table.ForeignKey(
                        name: "FK_MixLogs_Fodders_FodderId",
                        column: x => x.FodderId,
                        principalTable: "Fodders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MixLogs_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InjectLogs",
                columns: table => new
                {
                    HerdId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MedicineId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    InjectDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2020, 12, 10, 20, 7, 58, 767, DateTimeKind.Local).AddTicks(7036)),
                    Amount = table.Column<double>(type: "float", nullable: false, defaultValue: 0.0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InjectLogs", x => new { x.HerdId, x.MedicineId });
                    table.ForeignKey(
                        name: "FK_InjectLogs_BoarHerds_HerdId",
                        column: x => x.HerdId,
                        principalTable: "BoarHerds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InjectLogs_Medicines_MedicineId",
                        column: x => x.MedicineId,
                        principalTable: "Medicines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseLogs",
                columns: table => new
                {
                    PurchaseId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 0m),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2020, 12, 10, 20, 7, 58, 772, DateTimeKind.Local).AddTicks(6953)),
                    Amount = table.Column<double>(type: "float", nullable: false, defaultValue: 0.0),
                    IngredientId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    MedicineId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseLogs", x => x.PurchaseId);
                    table.ForeignKey(
                        name: "FK_PurchaseLogs_Ingredients_IngredientId",
                        column: x => x.IngredientId,
                        principalTable: "Ingredients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PurchaseLogs_Medicines_MedicineId",
                        column: x => x.MedicineId,
                        principalTable: "Medicines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Boars_HerdId",
                table: "Boars",
                column: "HerdId");

            migrationBuilder.CreateIndex(
                name: "IX_InjectLogs_MedicineId",
                table: "InjectLogs",
                column: "MedicineId");

            migrationBuilder.CreateIndex(
                name: "IX_MixLogs_IngredientId",
                table: "MixLogs",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseLogs_IngredientId",
                table: "PurchaseLogs",
                column: "IngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseLogs_MedicineId",
                table: "PurchaseLogs",
                column: "MedicineId");

            migrationBuilder.CreateIndex(
                name: "IX_SeedLogs_FodderId",
                table: "SeedLogs",
                column: "FodderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Boars");

            migrationBuilder.DropTable(
                name: "InjectLogs");

            migrationBuilder.DropTable(
                name: "MixLogs");

            migrationBuilder.DropTable(
                name: "PurchaseLogs");

            migrationBuilder.DropTable(
                name: "SeedLogs");

            migrationBuilder.DropTable(
                name: "Ingredients");

            migrationBuilder.DropTable(
                name: "Medicines");

            migrationBuilder.DropTable(
                name: "BoarHerds");

            migrationBuilder.DropTable(
                name: "Fodders");
        }
    }
}
