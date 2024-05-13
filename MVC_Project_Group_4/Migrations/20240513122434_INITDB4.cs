using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MVC_Project_Group_4.Migrations
{
    /// <inheritdoc />
    public partial class INITDB4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "1c41cf4f-f9c1-4946-830a-e81523218a46");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "45e52f2a-9581-466c-8c8a-dd47e91fd70a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31625cb3-c787-4d2c-9ab3-b540b9b5b572", "AQAAAAIAAYagAAAAENkukitIfnNACCw6gx8yBQGTaodsWwjOCRhM1+2bHINu/CY1CsnAM+I0lf9P1QFIGg==", "b94d7732-6313-47dd-8b37-39ab73a0c1ae" });

            migrationBuilder.UpdateData(
                table: "EkstraMalzemeler",
                keyColumn: "EkstraMalzemeID",
                keyValue: 1,
                column: "PicturePath",
                value: "~/wwwroot/Pictures/Hamburgerler/Ek_Urunler/marul.jpg");

            migrationBuilder.UpdateData(
                table: "EkstraMalzemeler",
                keyColumn: "EkstraMalzemeID",
                keyValue: 2,
                column: "PicturePath",
                value: "~/wwwroot/Pictures/Hamburgerler/Ek_Urunler/Domates.jpg ");

            migrationBuilder.UpdateData(
                table: "EkstraMalzemeler",
                keyColumn: "EkstraMalzemeID",
                keyValue: 3,
                column: "PicturePath",
                value: "~/wwwroot/Pictures/Hamburgerler/Ek_Urunler/Tursu.jpg ");

            migrationBuilder.UpdateData(
                table: "EkstraMalzemeler",
                keyColumn: "EkstraMalzemeID",
                keyValue: 4,
                column: "PicturePath",
                value: " ~/wwwroot/Pictures/Hamburgerler/Ek_Urunler/sogan.jpg");

            migrationBuilder.UpdateData(
                table: "EkstraMalzemeler",
                keyColumn: "EkstraMalzemeID",
                keyValue: 5,
                column: "PicturePath",
                value: "~/wwwroot/Pictures/Hamburgerler/Ek_Urunler/Mayonez.jpg ");

            migrationBuilder.UpdateData(
                table: "EkstraMalzemeler",
                keyColumn: "EkstraMalzemeID",
                keyValue: 6,
                column: "PicturePath",
                value: "~/wwwroot/Pictures/Hamburgerler/Ek_Urunler/Ketcap.jpg ");

            migrationBuilder.UpdateData(
                table: "EkstraMalzemeler",
                keyColumn: "EkstraMalzemeID",
                keyValue: 7,
                column: "PicturePath",
                value: "~/wwwroot/Pictures/Hamburgerler/Ek_Urunler/Tirtikli_patates_kizartmasi.jpg ");

            migrationBuilder.UpdateData(
                table: "EkstraMalzemeler",
                keyColumn: "EkstraMalzemeID",
                keyValue: 8,
                column: "PicturePath",
                value: "~/wwwroot/Pictures/Hamburgerler/Ek_Urunler/Sogan_Halkasi.jpg ");

            migrationBuilder.UpdateData(
                table: "EkstraMalzemeler",
                keyColumn: "EkstraMalzemeID",
                keyValue: 9,
                column: "PicturePath",
                value: "~/wwwroot/Pictures/Hamburgerler/Ek_Urunler/Barbaku_sos.jpg");

            migrationBuilder.UpdateData(
                table: "EkstraMalzemeler",
                keyColumn: "EkstraMalzemeID",
                keyValue: 10,
                column: "PicturePath",
                value: "~/wwwroot/Pictures/Hamburgerler/Ek_Urunler/Ranche_sos.jpg");

            migrationBuilder.UpdateData(
                table: "EkstraMalzemeler",
                keyColumn: "EkstraMalzemeID",
                keyValue: 11,
                column: "PicturePath",
                value: "~/wwwroot/Pictures/Hamburgerler/Ek_Urunler/Mini_Salata.jpg");

            migrationBuilder.UpdateData(
                table: "EkstraMalzemeler",
                keyColumn: "EkstraMalzemeID",
                keyValue: 12,
                column: "PicturePath",
                value: "~/wwwroot/Pictures/Hamburgerler/Ek_Urunler/Pastirma.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                table: "EkstraMalzemeler",
                keyColumn: "EkstraMalzemeID",
                keyValue: 1,
                column: "PicturePath",
                value: " ");

            migrationBuilder.UpdateData(
                table: "EkstraMalzemeler",
                keyColumn: "EkstraMalzemeID",
                keyValue: 2,
                column: "PicturePath",
                value: " ");

            migrationBuilder.UpdateData(
                table: "EkstraMalzemeler",
                keyColumn: "EkstraMalzemeID",
                keyValue: 3,
                column: "PicturePath",
                value: " ");

            migrationBuilder.UpdateData(
                table: "EkstraMalzemeler",
                keyColumn: "EkstraMalzemeID",
                keyValue: 4,
                column: "PicturePath",
                value: " ");

            migrationBuilder.UpdateData(
                table: "EkstraMalzemeler",
                keyColumn: "EkstraMalzemeID",
                keyValue: 5,
                column: "PicturePath",
                value: " ");

            migrationBuilder.UpdateData(
                table: "EkstraMalzemeler",
                keyColumn: "EkstraMalzemeID",
                keyValue: 6,
                column: "PicturePath",
                value: " ");

            migrationBuilder.UpdateData(
                table: "EkstraMalzemeler",
                keyColumn: "EkstraMalzemeID",
                keyValue: 7,
                column: "PicturePath",
                value: " ");

            migrationBuilder.UpdateData(
                table: "EkstraMalzemeler",
                keyColumn: "EkstraMalzemeID",
                keyValue: 8,
                column: "PicturePath",
                value: " ");

            migrationBuilder.UpdateData(
                table: "EkstraMalzemeler",
                keyColumn: "EkstraMalzemeID",
                keyValue: 9,
                column: "PicturePath",
                value: " ");

            migrationBuilder.UpdateData(
                table: "EkstraMalzemeler",
                keyColumn: "EkstraMalzemeID",
                keyValue: 10,
                column: "PicturePath",
                value: " ");

            migrationBuilder.UpdateData(
                table: "EkstraMalzemeler",
                keyColumn: "EkstraMalzemeID",
                keyValue: 11,
                column: "PicturePath",
                value: " ");

            migrationBuilder.UpdateData(
                table: "EkstraMalzemeler",
                keyColumn: "EkstraMalzemeID",
                keyValue: 12,
                column: "PicturePath",
                value: "");
        }
    }
}
