using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Project_Group_4.Migrations
{
    /// <inheritdoc />
    public partial class INITDB2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Boy",
                table: "Menuler",
                type: "varchar(10)",
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "680e19c8-ceac-4387-8733-9c876915c92c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "00801de4-4d5c-4441-8b47-a5ad322ab8f9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c0bee0ad-be98-401c-930f-4bb2dedbfaa3", "AQAAAAIAAYagAAAAEKp3+ZZtyGpVGfeVKSDkTNvMkW9RlAYsY02eulu3syegxvXh2qAiriRYeNPtaiPyAg==", "bf599c59-caa7-4d48-b55c-550c7bca2ee9" });

            migrationBuilder.UpdateData(
                table: "Menuler",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "Boy",
                value: "Kucuk");

            migrationBuilder.UpdateData(
                table: "Menuler",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "Boy",
                value: null);

            migrationBuilder.UpdateData(
                table: "Menuler",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "Boy",
                value: null);

            migrationBuilder.UpdateData(
                table: "Menuler",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "Boy",
                value: null);

            migrationBuilder.UpdateData(
                table: "Menuler",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "Boy",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Boy",
                table: "Menuler",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "128e2d57-e574-4dd1-89ce-1265c77d1c3f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "c61a743e-144a-4d6c-bc44-00f648ce5676");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5110901b-2521-4bc4-a933-9e4a0d923fd7", "AQAAAAIAAYagAAAAEIonuK9u4+g+II/xytwBMVLwWWibb3rf6FGb7AI6IZzc/+qPkbWtM7edmxuI8XaXbg==", "4c1eb146-a68e-4525-abee-871d46213e87" });

            migrationBuilder.UpdateData(
                table: "Menuler",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "Boy",
                value: null);

            migrationBuilder.UpdateData(
                table: "Menuler",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "Boy",
                value: null);

            migrationBuilder.UpdateData(
                table: "Menuler",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "Boy",
                value: null);

            migrationBuilder.UpdateData(
                table: "Menuler",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "Boy",
                value: null);

            migrationBuilder.UpdateData(
                table: "Menuler",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "Boy",
                value: null);
        }
    }
}
