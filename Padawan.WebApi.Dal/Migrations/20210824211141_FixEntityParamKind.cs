using Microsoft.EntityFrameworkCore.Migrations;

namespace Padawan.WebApi.Dal.Migrations
{
    public partial class FixEntityParamKind : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "Users",
                newName: "Update");

            migrationBuilder.RenameColumn(
                name: "UpdateDate",
                table: "Photos",
                newName: "Update");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Users",
                type: "nvarchar(75)",
                maxLength: 75,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 75);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(75)",
                maxLength: 75,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 75);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Update",
                table: "Users",
                newName: "UpdateDate");

            migrationBuilder.RenameColumn(
                name: "Update",
                table: "Photos",
                newName: "UpdateDate");

            migrationBuilder.AlterColumn<int>(
                name: "Name",
                table: "Users",
                type: "int",
                maxLength: 75,
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(75)",
                oldMaxLength: 75,
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Email",
                table: "Users",
                type: "int",
                maxLength: 75,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(75)",
                oldMaxLength: 75);
        }
    }
}
