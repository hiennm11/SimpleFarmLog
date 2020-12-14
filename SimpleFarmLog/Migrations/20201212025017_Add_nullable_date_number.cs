using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SimpleFarmLog.Migrations
{
    public partial class Add_nullable_date_number : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "SeedDate",
                table: "SeedLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 12, 9, 50, 17, 84, DateTimeKind.Local).AddTicks(1709),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 11, 8, 41, 19, 939, DateTimeKind.Local).AddTicks(5132));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PurchaseDate",
                table: "PurchaseLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 12, 9, 50, 17, 85, DateTimeKind.Local).AddTicks(9636),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 11, 8, 41, 19, 941, DateTimeKind.Local).AddTicks(7883));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MixDate",
                table: "MixLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 12, 9, 50, 17, 82, DateTimeKind.Local).AddTicks(8415),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 11, 8, 41, 19, 938, DateTimeKind.Local).AddTicks(12));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InjectDate",
                table: "InjectLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 12, 9, 50, 17, 81, DateTimeKind.Local).AddTicks(3583),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 11, 8, 41, 19, 936, DateTimeKind.Local).AddTicks(4046));

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Boars",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2020, 12, 12, 9, 50, 17, 63, DateTimeKind.Local).AddTicks(455),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 11, 8, 41, 19, 915, DateTimeKind.Local).AddTicks(8726));

            migrationBuilder.AlterColumn<int>(
                name: "Number",
                table: "Boars",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Number",
                table: "BoarHerds",
                type: "int",
                nullable: true,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InitDate",
                table: "BoarHerds",
                type: "datetime2",
                nullable: true,
                defaultValue: new DateTime(2020, 12, 12, 9, 50, 17, 70, DateTimeKind.Local).AddTicks(1692),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 11, 8, 41, 19, 923, DateTimeKind.Local).AddTicks(8672));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "SeedDate",
                table: "SeedLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 11, 8, 41, 19, 939, DateTimeKind.Local).AddTicks(5132),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 12, 9, 50, 17, 84, DateTimeKind.Local).AddTicks(1709));

            migrationBuilder.AlterColumn<DateTime>(
                name: "PurchaseDate",
                table: "PurchaseLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 11, 8, 41, 19, 941, DateTimeKind.Local).AddTicks(7883),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 12, 9, 50, 17, 85, DateTimeKind.Local).AddTicks(9636));

            migrationBuilder.AlterColumn<DateTime>(
                name: "MixDate",
                table: "MixLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 11, 8, 41, 19, 938, DateTimeKind.Local).AddTicks(12),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 12, 9, 50, 17, 82, DateTimeKind.Local).AddTicks(8415));

            migrationBuilder.AlterColumn<DateTime>(
                name: "InjectDate",
                table: "InjectLogs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 11, 8, 41, 19, 936, DateTimeKind.Local).AddTicks(4046),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2020, 12, 12, 9, 50, 17, 81, DateTimeKind.Local).AddTicks(3583));

            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Boars",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 11, 8, 41, 19, 915, DateTimeKind.Local).AddTicks(8726),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 12, 12, 9, 50, 17, 63, DateTimeKind.Local).AddTicks(455));

            migrationBuilder.AlterColumn<int>(
                name: "Number",
                table: "Boars",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "Number",
                table: "BoarHerds",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true,
                oldDefaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "InitDate",
                table: "BoarHerds",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2020, 12, 11, 8, 41, 19, 923, DateTimeKind.Local).AddTicks(8672),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true,
                oldDefaultValue: new DateTime(2020, 12, 12, 9, 50, 17, 70, DateTimeKind.Local).AddTicks(1692));
        }
    }
}
