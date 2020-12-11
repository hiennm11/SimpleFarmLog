using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SimpleFarmLog.Migrations
{
    public partial class FixType_Price_Col : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "SeedDate",
                table: "SeedLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 11, 8, 41, 19, 939, DateTimeKind.Local).AddTicks(5132),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 10, 20, 7, 58, 770, DateTimeKind.Local).AddTicks(9925));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PurchaseDate",
                table: "PurchaseLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 11, 8, 41, 19, 941, DateTimeKind.Local).AddTicks(7883),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 10, 20, 7, 58, 772, DateTimeKind.Local).AddTicks(6953));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MixDate",
                table: "MixLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 11, 8, 41, 19, 938, DateTimeKind.Local).AddTicks(12),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 10, 20, 7, 58, 769, DateTimeKind.Local).AddTicks(1187));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InjectDate",
                table: "InjectLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 11, 8, 41, 19, 936, DateTimeKind.Local).AddTicks(4046),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 10, 20, 7, 58, 767, DateTimeKind.Local).AddTicks(7036));

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Boars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 11, 8, 41, 19, 915, DateTimeKind.Local).AddTicks(8726),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 10, 20, 7, 58, 748, DateTimeKind.Local).AddTicks(5337));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InitDate",
                table: "BoarHerds",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 11, 8, 41, 19, 923, DateTimeKind.Local).AddTicks(8672),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 10, 20, 7, 58, 756, DateTimeKind.Local).AddTicks(6187));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "SeedDate",
                table: "SeedLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 10, 20, 7, 58, 770, DateTimeKind.Local).AddTicks(9925),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 11, 8, 41, 19, 939, DateTimeKind.Local).AddTicks(5132));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PurchaseDate",
                table: "PurchaseLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 10, 20, 7, 58, 772, DateTimeKind.Local).AddTicks(6953),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 11, 8, 41, 19, 941, DateTimeKind.Local).AddTicks(7883));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MixDate",
                table: "MixLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 10, 20, 7, 58, 769, DateTimeKind.Local).AddTicks(1187),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 11, 8, 41, 19, 938, DateTimeKind.Local).AddTicks(12));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InjectDate",
                table: "InjectLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 10, 20, 7, 58, 767, DateTimeKind.Local).AddTicks(7036),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 11, 8, 41, 19, 936, DateTimeKind.Local).AddTicks(4046));

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Boars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 10, 20, 7, 58, 748, DateTimeKind.Local).AddTicks(5337),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 11, 8, 41, 19, 915, DateTimeKind.Local).AddTicks(8726));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InitDate",
                table: "BoarHerds",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 10, 20, 7, 58, 756, DateTimeKind.Local).AddTicks(6187),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 11, 8, 41, 19, 923, DateTimeKind.Local).AddTicks(8672));
        }
    }
}
