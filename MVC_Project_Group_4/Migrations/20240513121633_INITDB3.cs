using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Project_Group_4.Migrations
{
    /// <inheritdoc />
    public partial class INITDB3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                value: "0e808479-d005-437c-90b2-a020ea7c8296");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "3c3ce716-0ed1-4a8d-a64c-b203c3ced988");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1d24168-709b-48e6-94dd-612baf1fce67", "AQAAAAIAAYagAAAAEEVnFaKEPazb94vWYCunsFiCgKHjp3lDiqS5/Niwq0tWJcCD7J+xWqQJ3kFi+mubmw==", "cc899bdf-3263-4683-8b52-117a48c3ad05" });

            migrationBuilder.UpdateData(
                table: "Hamburgerler",
                keyColumn: "HamburgerID",
                keyValue: 1,
                column: "PicturePath",
                value: "~/wwwroot/Pictures/Hamburgerler/CheeseBurger.jpg");

            migrationBuilder.UpdateData(
                table: "Hamburgerler",
                keyColumn: "HamburgerID",
                keyValue: 2,
                column: "PicturePath",
                value: "~/wwwroot/Pictures/Hamburgerler/Big_King.jpg");

            migrationBuilder.UpdateData(
                table: "Hamburgerler",
                keyColumn: "HamburgerID",
                keyValue: 3,
                column: "PicturePath",
                value: "~/wwwroot/Pictures/Hamburgerler/Whoper.jpg");

            migrationBuilder.UpdateData(
                table: "Hamburgerler",
                keyColumn: "HamburgerID",
                keyValue: 4,
                column: "PicturePath",
                value: "~/wwwroot/Pictures/Hamburgerler/Triple_Whopper.jpg");

            migrationBuilder.UpdateData(
                table: "Hamburgerler",
                keyColumn: "HamburgerID",
                keyValue: 5,
                column: "PicturePath",
                value: "~/wwwroot/Pictures/Hamburgerler/jr_bigmac.jpg");

            migrationBuilder.UpdateData(
                table: "Hamburgerler",
                keyColumn: "HamburgerID",
                keyValue: 6,
                column: "PicturePath",
                value: "~/wwwroot/Pictures/Hamburgerler/Pastırmalı_burger.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                columns: new[] { "EkstraMalzemeID", "PicturePath" },
                values: new object[] { 0, "" });

            migrationBuilder.UpdateData(
                table: "Hamburgerler",
                keyColumn: "HamburgerID",
                keyValue: 2,
                columns: new[] { "EkstraMalzemeID", "PicturePath" },
                values: new object[] { 0, "" });

            migrationBuilder.UpdateData(
                table: "Hamburgerler",
                keyColumn: "HamburgerID",
                keyValue: 3,
                columns: new[] { "EkstraMalzemeID", "PicturePath" },
                values: new object[] { 0, "" });

            migrationBuilder.UpdateData(
                table: "Hamburgerler",
                keyColumn: "HamburgerID",
                keyValue: 4,
                columns: new[] { "EkstraMalzemeID", "PicturePath" },
                values: new object[] { 0, "" });

            migrationBuilder.UpdateData(
                table: "Hamburgerler",
                keyColumn: "HamburgerID",
                keyValue: 5,
                columns: new[] { "EkstraMalzemeID", "PicturePath" },
                values: new object[] { 0, "" });

            migrationBuilder.UpdateData(
                table: "Hamburgerler",
                keyColumn: "HamburgerID",
                keyValue: 6,
                columns: new[] { "EkstraMalzemeID", "PicturePath" },
                values: new object[] { 0, "" });

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
    }
}
