using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SimpleFarmLog.Migrations
{
    public partial class Add_Auto_Generate_Id : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "SeedDate",
                table: "SeedLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 12, 15, 52, 57, 741, DateTimeKind.Local).AddTicks(8786),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 12, 9, 50, 17, 84, DateTimeKind.Local).AddTicks(1709));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PurchaseDate",
                table: "PurchaseLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 12, 15, 52, 57, 744, DateTimeKind.Local).AddTicks(1430),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 12, 9, 50, 17, 85, DateTimeKind.Local).AddTicks(9636));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MixDate",
                table: "MixLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 12, 15, 52, 57, 740, DateTimeKind.Local).AddTicks(3547),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 12, 9, 50, 17, 82, DateTimeKind.Local).AddTicks(8415));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InjectDate",
                table: "InjectLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 12, 15, 52, 57, 738, DateTimeKind.Local).AddTicks(5409),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 12, 9, 50, 17, 81, DateTimeKind.Local).AddTicks(3583));

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Boars",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2020, 12, 12, 15, 52, 57, 716, DateTimeKind.Local).AddTicks(9486),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 12, 12, 9, 50, 17, 63, DateTimeKind.Local).AddTicks(455));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InitDate",
                table: "BoarHerds",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2020, 12, 12, 15, 52, 57, 725, DateTimeKind.Local).AddTicks(1785),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 12, 12, 9, 50, 17, 70, DateTimeKind.Local).AddTicks(1692));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "SeedDate",
                table: "SeedLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 12, 9, 50, 17, 84, DateTimeKind.Local).AddTicks(1709),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 12, 15, 52, 57, 741, DateTimeKind.Local).AddTicks(8786));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PurchaseDate",
                table: "PurchaseLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 12, 9, 50, 17, 85, DateTimeKind.Local).AddTicks(9636),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 12, 15, 52, 57, 744, DateTimeKind.Local).AddTicks(1430));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MixDate",
                table: "MixLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 12, 9, 50, 17, 82, DateTimeKind.Local).AddTicks(8415),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 12, 15, 52, 57, 740, DateTimeKind.Local).AddTicks(3547));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InjectDate",
                table: "InjectLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 12, 9, 50, 17, 81, DateTimeKind.Local).AddTicks(3583),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 12, 15, 52, 57, 738, DateTimeKind.Local).AddTicks(5409));

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Boars",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2020, 12, 12, 9, 50, 17, 63, DateTimeKind.Local).AddTicks(455),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 12, 12, 15, 52, 57, 716, DateTimeKind.Local).AddTicks(9486));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InitDate",
                table: "BoarHerds",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2020, 12, 12, 9, 50, 17, 70, DateTimeKind.Local).AddTicks(1692),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 12, 12, 15, 52, 57, 725, DateTimeKind.Local).AddTicks(1785));
        }
    }
}
