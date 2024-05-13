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
            migrationBuilder.AddColumn<int>(
                name: "EkstraMalzemeID",
                table: "Hamburgerler",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HamburgerID",
                table: "EkstraMalzemeler",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "51173f2f-dff8-44dd-a805-a060aed79d2b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "639ddcee-c567-4dc0-be81-7bc8243b941b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09d75697-19cd-46ff-bc5e-90c84e6a6009", "AQAAAAIAAYagAAAAEPZJJjBTm8glD69tnRJTdSah+/nvnRz3cd2iJPr0vMwal/VhOrbBFFVaKlIPz9Zyzg==", "5811e235-74b8-4a1a-8c7b-eb8a74424c81" });

            migrationBuilder.UpdateData(
                table: "EkstraMalzemeler",
                keyColumn: "EkstraMalzemeID",
                keyValue: 1,
                column: "HamburgerID",
                value: null);

            migrationBuilder.UpdateData(
                table: "EkstraMalzemeler",
                keyColumn: "EkstraMalzemeID",
                keyValue: 2,
                column: "HamburgerID",
                value: null);

            migrationBuilder.UpdateData(
                table: "EkstraMalzemeler",
                keyColumn: "EkstraMalzemeID",
                keyValue: 3,
                column: "HamburgerID",
                value: null);

            migrationBuilder.UpdateData(
                table: "EkstraMalzemeler",
                keyColumn: "EkstraMalzemeID",
                keyValue: 4,
                column: "HamburgerID",
                value: null);

            migrationBuilder.UpdateData(
                table: "EkstraMalzemeler",
                keyColumn: "EkstraMalzemeID",
                keyValue: 5,
                column: "HamburgerID",
                value: null);

            migrationBuilder.UpdateData(
                table: "EkstraMalzemeler",
                keyColumn: "EkstraMalzemeID",
                keyValue: 6,
                column: "HamburgerID",
                value: null);

            migrationBuilder.UpdateData(
                table: "EkstraMalzemeler",
                keyColumn: "EkstraMalzemeID",
                keyValue: 7,
                column: "HamburgerID",
                value: null);

            migrationBuilder.UpdateData(
                table: "EkstraMalzemeler",
                keyColumn: "EkstraMalzemeID",
                keyValue: 8,
                column: "HamburgerID",
                value: null);

            migrationBuilder.UpdateData(
                table: "EkstraMalzemeler",
                keyColumn: "EkstraMalzemeID",
                keyValue: 9,
                column: "HamburgerID",
                value: null);

            migrationBuilder.UpdateData(
                table: "EkstraMalzemeler",
                keyColumn: "EkstraMalzemeID",
                keyValue: 10,
                column: "HamburgerID",
                value: null);

            migrationBuilder.UpdateData(
                table: "EkstraMalzemeler",
                keyColumn: "EkstraMalzemeID",
                keyValue: 11,
                column: "HamburgerID",
                value: null);

            migrationBuilder.UpdateData(
                table: "EkstraMalzemeler",
                keyColumn: "EkstraMalzemeID",
                keyValue: 12,
                column: "HamburgerID",
                value: null);

            migrationBuilder.UpdateData(
                table: "Hamburgerler",
                keyColumn: "HamburgerID",
                keyValue: 1,
                column: "EkstraMalzemeID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Hamburgerler",
                keyColumn: "HamburgerID",
                keyValue: 2,
                column: "EkstraMalzemeID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Hamburgerler",
                keyColumn: "HamburgerID",
                keyValue: 3,
                column: "EkstraMalzemeID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Hamburgerler",
                keyColumn: "HamburgerID",
                keyValue: 4,
                column: "EkstraMalzemeID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Hamburgerler",
                keyColumn: "HamburgerID",
                keyValue: 5,
                column: "EkstraMalzemeID",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Hamburgerler",
                keyColumn: "HamburgerID",
                keyValue: 6,
                column: "EkstraMalzemeID",
                value: 0);

            migrationBuilder.CreateIndex(
                name: "IX_EkstraMalzemeler_HamburgerID",
                table: "EkstraMalzemeler",
                column: "HamburgerID");

            migrationBuilder.AddForeignKey(
                name: "FK_EkstraMalzemeler_Hamburgerler_HamburgerID",
                table: "EkstraMalzemeler",
                column: "HamburgerID",
                principalTable: "Hamburgerler",
                principalColumn: "HamburgerID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EkstraMalzemeler_Hamburgerler_HamburgerID",
                table: "EkstraMalzemeler");

            migrationBuilder.DropIndex(
                name: "IX_EkstraMalzemeler_HamburgerID",
                table: "EkstraMalzemeler");

            migrationBuilder.DropColumn(
                name: "EkstraMalzemeID",
                table: "Hamburgerler");

            migrationBuilder.DropColumn(
                name: "HamburgerID",
                table: "EkstraMalzemeler");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "00f00aff-db64-4a95-8e48-570dbf33e388");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "0cc49315-65cc-41fa-8ab9-e0c4c3feaa39");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7d19a67-c0cd-45ff-8bc9-6af0eb3e3f42", "AQAAAAIAAYagAAAAEL98eUbPFAAP3eri4DdKJB5RxfRRj3JvLWKY7uRZdRM7WHOmifiobQZjmFt6iUjAOw==", "59ec8ff6-47a2-4bae-914f-9d19513f5d72" });
        }
    }
}
