using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SimpleFarmLog.Migrations
{
    public partial class Remove_default_date_value : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "SeedDate",
                table: "SeedLogs",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 12, 15, 52, 57, 741, DateTimeKind.Local).AddTicks(8786));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PurchaseDate",
                table: "PurchaseLogs",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 12, 15, 52, 57, 744, DateTimeKind.Local).AddTicks(1430));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MixDate",
                table: "MixLogs",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 12, 15, 52, 57, 740, DateTimeKind.Local).AddTicks(3547));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InjectDate",
                table: "InjectLogs",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 12, 15, 52, 57, 738, DateTimeKind.Local).AddTicks(5409));

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Boars",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 12, 12, 15, 52, 57, 716, DateTimeKind.Local).AddTicks(9486));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InitDate",
                table: "BoarHerds",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 12, 12, 15, 52, 57, 725, DateTimeKind.Local).AddTicks(1785));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "SeedDate",
                table: "SeedLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 12, 15, 52, 57, 741, DateTimeKind.Local).AddTicks(8786),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "PurchaseDate",
                table: "PurchaseLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 12, 15, 52, 57, 744, DateTimeKind.Local).AddTicks(1430),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "MixDate",
                table: "MixLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 12, 15, 52, 57, 740, DateTimeKind.Local).AddTicks(3547),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "InjectDate",
                table: "InjectLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 12, 15, 52, 57, 738, DateTimeKind.Local).AddTicks(5409),
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Boars",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2020, 12, 12, 15, 52, 57, 716, DateTimeKind.Local).AddTicks(9486),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InitDate",
                table: "BoarHerds",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2020, 12, 12, 15, 52, 57, 725, DateTimeKind.Local).AddTicks(1785),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);
        }
    }
}
