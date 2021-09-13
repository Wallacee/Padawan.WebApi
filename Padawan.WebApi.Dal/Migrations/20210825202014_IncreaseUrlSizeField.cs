using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Padawan.WebApi.Dal.Migrations
{
    public partial class IncreaseUrlSizeField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 25, 17, 20, 13, 549, DateTimeKind.Local).AddTicks(4945),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 8, 24, 22, 8, 29, 508, DateTimeKind.Local).AddTicks(9459));

            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "Photos",
                type: "nvarchar(1000)",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Photos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 25, 17, 20, 13, 532, DateTimeKind.Local).AddTicks(1643),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 8, 24, 22, 8, 29, 482, DateTimeKind.Local).AddTicks(5886));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 24, 22, 8, 29, 508, DateTimeKind.Local).AddTicks(9459),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 8, 25, 17, 20, 13, 549, DateTimeKind.Local).AddTicks(4945));

            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "Photos",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(1000)",
                oldMaxLength: 1000);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreationDate",
                table: "Photos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2021, 8, 24, 22, 8, 29, 482, DateTimeKind.Local).AddTicks(5886),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2021, 8, 25, 17, 20, 13, 532, DateTimeKind.Local).AddTicks(1643));
        }
    }
}
