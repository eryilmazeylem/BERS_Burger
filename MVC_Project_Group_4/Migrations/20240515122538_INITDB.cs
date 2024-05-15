using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MVC_Project_Group_4.Migrations
{
    /// <inheritdoc />
    public partial class INITDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EkstraMalzemeler",
                columns: table => new
                {
                    EkstraMalzemeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Fiyat = table.Column<decimal>(type: "money", nullable: false),
                    Aciklama = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false),
                    PicturePath = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false),
                    Adet = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EkstraMalzemeler", x => x.EkstraMalzemeID);
                });

            migrationBuilder.CreateTable(
                name: "Hamburgerler",
                columns: table => new
                {
                    HamburgerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Fiyat = table.Column<decimal>(type: "money", nullable: false),
                    Aciklama = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false),
                    PicturePath = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false),
                    Adet = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hamburgerler", x => x.HamburgerID);
                });

            migrationBuilder.CreateTable(
                name: "Icecekler",
                columns: table => new
                {
                    IcecekID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Fiyat = table.Column<decimal>(type: "money", nullable: false),
                    Aciklama = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false),
                    PicturePath = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false),
                    Adet = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Icecekler", x => x.IcecekID);
                });

            migrationBuilder.CreateTable(
                name: "LoginVM",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EMail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoginVM", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Menuler",
                columns: table => new
                {
                    MenuID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Fiyat = table.Column<decimal>(type: "money", nullable: false),
                    Aciklama = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false),
                    PicturePath = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false),
                    Adet = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menuler", x => x.MenuID);
                });

            migrationBuilder.CreateTable(
                name: "RegisterVM",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConfirmPassword = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegisterVM", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Tatlilar",
                columns: table => new
                {
                    TatliID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Fiyat = table.Column<decimal>(type: "money", nullable: false),
                    Aciklama = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false),
                    PicturePath = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false),
                    Adet = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tatlilar", x => x.TatliID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Siparisler",
                columns: table => new
                {
                    SiparisID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiparisDetayAciklama = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false),
                    Boy = table.Column<int>(type: "int", nullable: false),
                    Adet = table.Column<int>(type: "int", nullable: false),
                    SiparisTarihi = table.Column<DateTime>(type: "datetime", nullable: false),
                    UyeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Siparisler", x => x.SiparisID);
                    table.ForeignKey(
                        name: "FK_Siparisler_AspNetUsers_UyeId",
                        column: x => x.UyeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MenuDetaylari",
                columns: table => new
                {
                    MenuDetayID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuID = table.Column<int>(type: "int", nullable: false),
                    EkMalzemeID = table.Column<int>(type: "int", nullable: false),
                    HamburgerID = table.Column<int>(type: "int", nullable: false),
                    IcecekID = table.Column<int>(type: "int", nullable: false),
                    TatlıID = table.Column<int>(type: "int", nullable: false),
                    EkstraMalzemeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MenuDetaylari", x => x.MenuDetayID);
                    table.ForeignKey(
                        name: "FK_MenuDetaylari_EkstraMalzemeler_EkstraMalzemeID",
                        column: x => x.EkstraMalzemeID,
                        principalTable: "EkstraMalzemeler",
                        principalColumn: "EkstraMalzemeID");
                    table.ForeignKey(
                        name: "FK_MenuDetaylari_Hamburgerler_HamburgerID",
                        column: x => x.HamburgerID,
                        principalTable: "Hamburgerler",
                        principalColumn: "HamburgerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MenuDetaylari_Icecekler_IcecekID",
                        column: x => x.IcecekID,
                        principalTable: "Icecekler",
                        principalColumn: "IcecekID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MenuDetaylari_Menuler_MenuID",
                        column: x => x.MenuID,
                        principalTable: "Menuler",
                        principalColumn: "MenuID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MenuDetaylari_Tatlilar_TatlıID",
                        column: x => x.TatlıID,
                        principalTable: "Tatlilar",
                        principalColumn: "TatliID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SiparisDetaylari",
                columns: table => new
                {
                    SiparisDetayID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SiparisID = table.Column<int>(type: "int", nullable: false),
                    EkMalzemeID = table.Column<int>(type: "int", nullable: false),
                    HamburgerID = table.Column<int>(type: "int", nullable: false),
                    IcecekID = table.Column<int>(type: "int", nullable: false),
                    TatliID = table.Column<int>(type: "int", nullable: false),
                    EkstraMalzemeID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiparisDetaylari", x => x.SiparisDetayID);
                    table.ForeignKey(
                        name: "FK_SiparisDetaylari_EkstraMalzemeler_EkstraMalzemeID",
                        column: x => x.EkstraMalzemeID,
                        principalTable: "EkstraMalzemeler",
                        principalColumn: "EkstraMalzemeID");
                    table.ForeignKey(
                        name: "FK_SiparisDetaylari_Hamburgerler_HamburgerID",
                        column: x => x.HamburgerID,
                        principalTable: "Hamburgerler",
                        principalColumn: "HamburgerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SiparisDetaylari_Icecekler_IcecekID",
                        column: x => x.IcecekID,
                        principalTable: "Icecekler",
                        principalColumn: "IcecekID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SiparisDetaylari_Siparisler_SiparisID",
                        column: x => x.SiparisID,
                        principalTable: "Siparisler",
                        principalColumn: "SiparisID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SiparisDetaylari_Tatlilar_TatliID",
                        column: x => x.TatliID,
                        principalTable: "Tatlilar",
                        principalColumn: "TatliID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SiparisMenuleri",
                columns: table => new
                {
                    SiparisMenuID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MenuID = table.Column<int>(type: "int", nullable: false),
                    SiparisID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiparisMenuleri", x => x.SiparisMenuID);
                    table.ForeignKey(
                        name: "FK_SiparisMenuleri_Menuler_MenuID",
                        column: x => x.MenuID,
                        principalTable: "Menuler",
                        principalColumn: "MenuID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SiparisMenuleri_Siparisler_SiparisID",
                        column: x => x.SiparisID,
                        principalTable: "Siparisler",
                        principalColumn: "SiparisID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "d8ebd358-df0a-467d-aadc-8c9241e4b780", "Yonetici", "YONETICI" },
                    { 2, "96ccdd83-fdd1-4aa9-bfea-e94a300b51a1", "Uye", "UYE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Adres", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { 1, 0, "Dunya", "bec7c6d1-6ac6-44ef-93fe-68f4338c23e3", "super@deneme.com", false, false, null, "SUPER@DENEME.COM", "SUPER@DENEME.COM", "AQAAAAIAAYagAAAAEGuNXXuutNPEMOHNZo9tR978OiaI/0o+cJXYRc2LSIIlaTJgCr5mhawWXs5SgyRDKA==", null, false, "cb0edbac-a035-4f74-9a1c-b495eb6fc375", false, "super@deneme.com" });

            migrationBuilder.InsertData(
                table: "EkstraMalzemeler",
                columns: new[] { "EkstraMalzemeID", "Aciklama", "Ad", "Adet", "Fiyat", "PicturePath" },
                values: new object[,]
                {
                    { 1, "Taza Marul", "Marul", 1, 2.5m, "marul.jpg" },
                    { 2, "Ayaş domatesi", "Domates", 1, 3.5m, "Domates.jpg " },
                    { 3, "Kornişon Turşusu", "Turşu", 1, 2.5m, "Tursu.jpg " },
                    { 4, "Karamelize Soğan", "Soğan", 1, 1.2m, "sogan.jpg" },
                    { 5, "1 paket mayonez", "Mayonez", 1, 0.5m, "Mayonez.jpg " },
                    { 6, "1 paket ketçap", "Ketçap", 1, 0.5m, "Ketcap.jpg " },
                    { 7, "Özel Baharat Soslu Tırtıklı Patates Kızartması", "Tırtıklı Patates Kızartması", 1, 20m, "Tirtikli_patates_kizartmasi.jpg " },
                    { 8, "6 Adet Kızarmış Soğan Halkası", "6'lı Soğan Halkası", 1, 30m, "Sogan_Halkasi.jpg " },
                    { 9, "1 paket Barbekü Sos", "Barbekü Sos", 1, 1m, "Barbaku_sos.jpg" },
                    { 10, "1 paket Ranch Sos", "Ranch Sos", 1, 1m, "Ranche_sos.jpg" },
                    { 11, "Mevsim Yeşillikleri ile yapılmış taze salata", "Mini Salata", 1, 10m, "Mini_Salata.jpg" },
                    { 12, "Dana Pastırma", "Pastırma", 3, 50m, "Pastirma.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Hamburgerler",
                columns: new[] { "HamburgerID", "Aciklama", "Ad", "Adet", "Fiyat", "PicturePath" },
                values: new object[,]
                {
                    { 1, "120g Burger köftesi ile cheddar peynirinin muhteşem uyumu...", "CheeseBurger", 1, 150m, "CheeseBurger.jpg" },
                    { 2, "150g Dana Burger köftesi + Göbek Salata + domates + turşu + BigKing Sos", "BigKing", 1, 180m, "Big_King.jpg" },
                    { 3, "120g Dana Eti + Göbek Salata + domates + turşu + soğan", "Whooper", 1, 180m, "Whoper.jpg" },
                    { 4, "360g Burger Göbek Salata + domates + turşu + soğan", "TripleWhooper", 1, 300m, "Triple_Whopper.jpg" },
                    { 5, "90g Burger köftesi + domates + mayonez + ketçap + turşu", "Jr BigMac", 1, 100m, "jr_bigmac.jpg" },
                    { 6, "150g Burger köftesi + Pastırma + domates + mayonez + ketçap + turşu", "Pastırmalı Burger", 1, 230m, "Pastırmalı_burger.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Icecekler",
                columns: new[] { "IcecekID", "Aciklama", "Ad", "Adet", "Fiyat", "PicturePath" },
                values: new object[,]
                {
                    { 1, "Kutu İçecek", "Coca-Cola", 1, 30m, "Coca_cola.jpg" },
                    { 2, "Kutu İçecek", "Coca-Cola-Zero", 1, 30m, "Coca_cola_zero.jpg" },
                    { 3, "Kutu İçecek", "Fanta", 1, 30m, "Fanta.jpg" },
                    { 4, "Kutu İçecek", "Sprite", 1, 30m, "Sprite.jpg" },
                    { 5, "Büyük Ayran", "Ayran", 1, 30m, "Buyuk_Ayran.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Menuler",
                columns: new[] { "MenuID", "Aciklama", "Ad", "Adet", "Fiyat", "PicturePath" },
                values: new object[,]
                {
                    { 1, "1 Adet Cheeseburger + Tırtıklı Patates Kızartması + 1 Adet Kutu İçecek", "Klasik Burger Menu", 1, 350m, "Klasik_burger_menu.jpg" },
                    { 2, "1 Adet Pastırmalı Burger + Tırtıklı Patates + 1 Adet Kutu İçecek", "Pastırmalı Burger Menu", 1, 350m, "Benim_3_lum.jpg" },
                    { 3, "2 Adet Cheeseburger + Tırtıklı Patates + 2 Kutu İçecek", "2'li Fırsat Menü", 1, 350m, "Bjk_Menusu.jpg" },
                    { 4, "3 Adet TripleWhooper Burger + 2 Adet Tırtıklı Patates + 3 Adet Kutu İçecek", "3'lü Jumbo Menü", 1, 450m, "3_lu_big_king.jpg" },
                    { 5, "1 Adet CheeseBurger + 6'lı Soğan Halkası + Tırtıklı Patataes + 1adet kutu içecek", "CheeseBurger & SoğanHalkası Menü", 1, 300m, "chicken_menu.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Tatlilar",
                columns: new[] { "TatliID", "Aciklama", "Ad", "Adet", "Fiyat", "PicturePath" },
                values: new object[,]
                {
                    { 1, "Çikolatalı ve dondurmalı enfes sufle", "Sufle", 1, 50m, "Cikolatali_sufle.jpg" },
                    { 2, "Nefis Püresi ile beraber elmalı tatlı damak zevkinize birebir", "Elmalı Tatlı", 1, 35m, "Elmali_tatli.jpg" },
                    { 3, "Çikolata parçacıklı muhteşem kurabiyelerimiz", "Çikolatalı Cookie", 1, 35m, "Cikolatali_cookie.jpg" },
                    { 4, "Leziz fırınlanmış sütlaça hayır diyemezsiniz...", "Sütlaç", 1, 40m, "~Sutlac.jpg" },
                    { 5, "Dondurmalı İrmik helvası", "İrmik Helvası", 1, 35m, "irmikhelvasi.jpg" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_MenuDetaylari_EkstraMalzemeID",
                table: "MenuDetaylari",
                column: "EkstraMalzemeID");

            migrationBuilder.CreateIndex(
                name: "IX_MenuDetaylari_HamburgerID",
                table: "MenuDetaylari",
                column: "HamburgerID");

            migrationBuilder.CreateIndex(
                name: "IX_MenuDetaylari_IcecekID",
                table: "MenuDetaylari",
                column: "IcecekID");

            migrationBuilder.CreateIndex(
                name: "IX_MenuDetaylari_MenuID",
                table: "MenuDetaylari",
                column: "MenuID");

            migrationBuilder.CreateIndex(
                name: "IX_MenuDetaylari_TatlıID",
                table: "MenuDetaylari",
                column: "TatlıID");

            migrationBuilder.CreateIndex(
                name: "IX_SiparisDetaylari_EkstraMalzemeID",
                table: "SiparisDetaylari",
                column: "EkstraMalzemeID");

            migrationBuilder.CreateIndex(
                name: "IX_SiparisDetaylari_HamburgerID",
                table: "SiparisDetaylari",
                column: "HamburgerID");

            migrationBuilder.CreateIndex(
                name: "IX_SiparisDetaylari_IcecekID",
                table: "SiparisDetaylari",
                column: "IcecekID");

            migrationBuilder.CreateIndex(
                name: "IX_SiparisDetaylari_SiparisID",
                table: "SiparisDetaylari",
                column: "SiparisID");

            migrationBuilder.CreateIndex(
                name: "IX_SiparisDetaylari_TatliID",
                table: "SiparisDetaylari",
                column: "TatliID");

            migrationBuilder.CreateIndex(
                name: "IX_Siparisler_UyeId",
                table: "Siparisler",
                column: "UyeId");

            migrationBuilder.CreateIndex(
                name: "IX_SiparisMenuleri_MenuID",
                table: "SiparisMenuleri",
                column: "MenuID");

            migrationBuilder.CreateIndex(
                name: "IX_SiparisMenuleri_SiparisID",
                table: "SiparisMenuleri",
                column: "SiparisID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "LoginVM");

            migrationBuilder.DropTable(
                name: "MenuDetaylari");

            migrationBuilder.DropTable(
                name: "RegisterVM");

            migrationBuilder.DropTable(
                name: "SiparisDetaylari");

            migrationBuilder.DropTable(
                name: "SiparisMenuleri");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "EkstraMalzemeler");

            migrationBuilder.DropTable(
                name: "Hamburgerler");

            migrationBuilder.DropTable(
                name: "Icecekler");

            migrationBuilder.DropTable(
                name: "Tatlilar");

            migrationBuilder.DropTable(
                name: "Menuler");

            migrationBuilder.DropTable(
                name: "Siparisler");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
