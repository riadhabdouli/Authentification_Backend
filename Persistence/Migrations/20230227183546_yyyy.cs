using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class yyyy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BasketItems");

            migrationBuilder.DropTable(
                name: "Offers");

            migrationBuilder.DropTable(
                name: "ProductProductImageFile");

            migrationBuilder.DropTable(
                name: "Products_Orders");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Baskets");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Sizes");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "BaseFiles");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "BaseFiles");

            migrationBuilder.DropColumn(
                name: "Showcase",
                table: "BaseFiles");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "d59fac99-de5f-4e70-b731-a45b2f18e4e8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "5665fb75-6f40-4a43-a550-ca7160dab08a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c6f8879c-fc74-4969-a248-49b0cf7a37b1", "AQAAAAEAACcQAAAAEI6DpsEB5EyWAT4nJ13uPpNM9/bAaQakuA4cPRUruNvHCIyxPdH0T0HSdcsIOy7s4A==", "efc1c49b-6f91-4738-b990-088bb9259e17" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "302abfe9-b69f-4322-b6c2-17c2399dbb31", "AQAAAAEAACcQAAAAEJCxHUv8p/oPUwDe+vdn4mLvydjlesmNjx8QXzaAJEa/MrV5v+eoNKGtB/2k/ltWPg==", "d82eb2bd-7a57-4a48-8bed-17636c35ae5b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "99022b12-bccc-478b-b2d8-be7af66abbaa", "AQAAAAEAACcQAAAAEI4qz62wjRkv7b6PNM7h91x6q7vwblYVYt+axUrlR7yr3zGI/9YdFvTXExinFTiw9w==", "60b2a013-dc0b-45d6-8066-307381b73485" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b11669f-e7bd-422d-aea8-6e5e82c8248a", "AQAAAAEAACcQAAAAEEEQpj6BjUF4bMh4+veWKPtflebW/CzYcGQGVYtKMr+gsmBGXRjUwVQ0mpmlvbdafw==", "b3d11341-62f5-4f04-b329-435cbae649d7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a60692a3-9837-406f-b4b2-04846592e743", "AQAAAAEAACcQAAAAEAO1d/bRGn7HiUMnCAbkWLgSrfqbbzGKbbrHMMIkgJdi9M1OOFuk4RDjUXAW0BgX4A==", "dc9d6df4-8f4a-4bed-a5bf-aae07c30123a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f7c6e6a6-ef88-46e3-bf15-9e035b753f1d", "AQAAAAEAACcQAAAAEIxGF1+AhCI2aS+9Y7aQTzKISd+KN9Es2oFKhWxpG0akfQsaN8MzJrrnUp6HxENjOQ==", "e6b9fe0c-cfad-4cfc-ad89-ef4318d60355" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ee08159-32a5-4f01-b22c-dd228a41544c", "AQAAAAEAACcQAAAAENvGvtJRF0AHTZaNWZBkBO+dMVo3KiObewzpU8gkw3CPC/k5T7RTJ4O3DC4OBeSpZA==", "60960b0c-8991-4b96-940f-0985f9ec4422" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f5682aa7-6d51-48e4-b300-abc2f5469015", "AQAAAAEAACcQAAAAEO+Bgu6LUeFb0xr90z8pvUUFu1cOFZPY3WRZ5QictCkeSftGQmT24SjXN6jkyEkphA==", "2ba98973-7fba-4d81-bf3b-2449cb31767b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5382a493-1a9d-42ef-ba66-1d4314a57b5a", "AQAAAAEAACcQAAAAENf37jEEmSBXS5xcRXP0hDIJBQEkLTTNDMufokQthcm+axeCs8qjFHUhbQio/9v/bw==", "40053246-4516-4884-84d9-e4245bb917a5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "BaseFiles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "BaseFiles",
                type: "decimal(14,2)",
                precision: 14,
                scale: 2,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Showcase",
                table: "BaseFiles",
                type: "bit",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Baskets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Baskets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Baskets_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(120)", maxLength: 120, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_Baskets_Id",
                        column: x => x.Id,
                        principalTable: "Baskets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<int>(type: "int", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    SizeId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsOfferable = table.Column<bool>(type: "bit", nullable: false),
                    IsSold = table.Column<bool>(type: "bit", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Sizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Sizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BasketItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BasketId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasketItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BasketItems_Baskets_BasketId",
                        column: x => x.BasketId,
                        principalTable: "Baskets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasketItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Offers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsAccepted = table.Column<bool>(type: "bit", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    OfferPrice = table.Column<decimal>(type: "decimal(14,2)", precision: 14, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Offers_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Offers_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductProductImageFile",
                columns: table => new
                {
                    ProductImageFilesId = table.Column<int>(type: "int", nullable: false),
                    ProductsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductProductImageFile", x => new { x.ProductImageFilesId, x.ProductsId });
                    table.ForeignKey(
                        name: "FK_ProductProductImageFile_BaseFiles_ProductImageFilesId",
                        column: x => x.ProductImageFilesId,
                        principalTable: "BaseFiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductProductImageFile_Products_ProductsId",
                        column: x => x.ProductsId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products_Orders",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products_Orders", x => new { x.ProductId, x.OrderId });
                    table.ForeignKey(
                        name: "FK_Products_Orders_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_Orders_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "437c07dd-2e04-4779-a547-c891f929f078");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "d65e4896-c3ba-4171-b845-d31cf19c46b5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88ecec39-c9c9-49a1-841c-24f808f75dbd", "AQAAAAEAACcQAAAAEFORh2iauVh0BkTS8epfI05UcXqQX+5g49tq8mtjn/7/LcvdoS732r6mA19sUdp5Qw==", "eec24e80-e320-497b-9e2a-28e293fea32a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22ddc840-0f45-40f4-833c-22f6ed739f4d", "AQAAAAEAACcQAAAAEMYBlBiHijmwXcQqz6+FqhvPYMgDdtOoIvSSCTNeUosU/+izM/cehA6kC11XIvAeTA==", "ba2fac79-eb0c-422f-a65f-d5b30e72dd3b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1938a2de-c910-4d95-9a1a-0084bce8a7ae", "AQAAAAEAACcQAAAAENbSjtj8Va0N5tlIybfTLFlbrZeVfN5RLPYXm0mCdo5q/pAJQ+y/tj+ByUSx+TLRnA==", "86684137-58e7-46df-a5c3-fdde2084b93a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3f4d4ef-5354-4408-8cfb-12a3102a19e2", "AQAAAAEAACcQAAAAEB7g0hKSOvLu92oxKnEkzppwqFJqs492ctMUbI9sDCIoDlWL3SbQJ115It0iX7G75g==", "dc3342dd-9d91-4da9-a3a8-e23216e873ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "716b2659-834f-4ff4-9482-3da5b4ec60b4", "AQAAAAEAACcQAAAAELLQkiUD/L9vZ2XtDva8exBmUxLRQR4gf5G1tS4+3wAKdqf2Xyb0/LQVaT2FJWm37Q==", "f9bcde65-17f4-443c-a5d2-2496b65aa6ee" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48bbaf9b-4287-4d79-90ea-6937fe5bbfcc", "AQAAAAEAACcQAAAAEHEP3DyFo1fdH6Edm7XU9+SuTdoHgmgrWLO+iGYkhhNVnMlJSubGp8SPfkVFe0mG4w==", "56dd15e6-252a-49f9-b221-d3e2f58f9d39" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2627adf0-7f21-44d8-bca6-d1f2698a14fb", "AQAAAAEAACcQAAAAEC58XM6neVS0kBjuX+Bv0cCARrjHf3szODg+NTVJxy3/0qA0b86aeA57n88rBi/qiw==", "802e2bc4-0266-41d5-b994-0d5d54758919" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8700327-77a3-4537-8854-384ee783f2b7", "AQAAAAEAACcQAAAAEFdV1LIW83A8kGpiRhvoDGu30T8dt8JAkOn7/ci6om9VO9tJo9IdvXA5ljF0F8mVcg==", "9660e8df-e6bc-4262-98b3-9c457a76c064" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc64bed8-1f57-414b-adac-5019d281aeda", "AQAAAAEAACcQAAAAEIFiOYIp/D+eiSSLhtyg3XUSDFPZ+wH90a0JbapZo67l8TxKa8aNIpX8ViHWbBghOQ==", "e5a037ac-8f72-4a5d-8415-32404f49cb32" });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "LCWAIKIKI" },
                    { 2, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "LCWAIKIKI Limited" },
                    { 3, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "LCWAIKIKI Modest" },
                    { 4, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "LCWAIKIKI Casual" },
                    { 5, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "LCWAIKIKI Vision" },
                    { 6, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "MIZALLE" },
                    { 7, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "BENETTON" },
                    { 8, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "BIANCA" },
                    { 9, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "QOOQ STORE" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mont" },
                    { 2, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Hırka ve Süveter" },
                    { 3, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kazak" },
                    { 4, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bluz" },
                    { 5, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gömlek" },
                    { 6, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Tişört" },
                    { 7, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Sweatshirt" },
                    { 8, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Jean" }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Ekru" },
                    { 2, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kırmızı" },
                    { 3, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Lacivert" },
                    { 4, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Açık Kahverengi" },
                    { 5, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Mavi" },
                    { 6, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Antrasit" },
                    { 7, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Koyu Gri" },
                    { 8, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Canlı Turuncu" },
                    { 9, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Bej Çizgili" },
                    { 10, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Beyaz" },
                    { 11, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Gri" },
                    { 12, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "İndigo Melanj" },
                    { 13, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Koyu Rodeo" },
                    { 14, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Optik Beyaz" }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "CreatedDate", "LastModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "XS" },
                    { 2, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "S" },
                    { 3, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "M" },
                    { 4, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "L" },
                    { 5, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "XL" },
                    { 6, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "2XL" },
                    { 7, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "3XL" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AppUserId", "BrandId", "CategoryId", "ColorId", "CreatedDate", "IsOfferable", "IsSold", "LastModifiedDate", "Name", "Price", "SizeId", "Stock" },
                values: new object[,]
                {
                    { 1, 1, 1, 1, 1, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, null, "Dik Yaka Erkek Deri Mont", 2699.99f, 1, 400 },
                    { 2, 1, 1, 1, 2, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, null, "Biker Yaka Erkek Deri Mont", 2699.99f, 1, 400 },
                    { 3, 1, 1, 1, 3, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, null, "Gömlek Yaka Erkek Şişme Mont", 2699.99f, 1, 400 },
                    { 4, 1, 4, 2, 4, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, null, "Kuşak Detaylı Uzun Kollu Kadın Triko Hırka", 499.99f, 2, 400 },
                    { 5, 2, 5, 2, 5, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, null, "Kapüşonlu Kendinden Desenli Kadın Süveter", 189.99f, 3, 400 },
                    { 6, 2, 6, 3, 6, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, null, "Balıkçı Yaka Uzun Kollu Erkek Triko Kazak", 79.99f, 3, 400 },
                    { 7, 2, 7, 3, 7, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, null, "Bisiklet Yaka Uzun Kollu Çizgili Erkek Triko Kazak", 149.99f, 4, 400 },
                    { 8, 2, 8, 4, 8, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, null, "Kalp Yaka Kolsız Kadın Blız", 449.99f, 4, 400 },
                    { 9, 3, 9, 4, 9, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, null, "Renk Bloklu Uzun Kollu Kadın Bluz", 599.99f, 5, 400 },
                    { 10, 3, 1, 5, 10, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, null, "Uzun Kollu Poplin Erkek Gömlek", 349.99f, 5, 400 },
                    { 11, 3, 2, 5, 11, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, null, "Uzun Kollu Keten Erkek Gömlek", 349.99f, 6, 400 },
                    { 12, 3, 3, 6, 12, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), false, false, null, "Tül Detaylı Kadın Lima Tişört", 199.99f, 6, 400 },
                    { 13, 4, 4, 6, 13, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, null, "Bisiklet Yaka Baskılı Kadın Tişört", 199.99f, 7, 400 },
                    { 14, 5, 5, 7, 14, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, null, "Baskılı Erkek Sweatshirt", 299.99f, 7, 400 },
                    { 15, 6, 6, 7, 11, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, null, "Outdoor Kapüşonlu Erkek Sweatshirt", 269.99f, 1, 400 },
                    { 16, 7, 7, 8, 12, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), true, false, null, "Tül Kemer Detaylı Kadın Jean", 349.99f, 1, 400 },
                    { 17, 8, 8, 8, 10, new DateTime(2022, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), true, true, null, "Cepli Kadın Flare Jean", 269.99f, 2, 400 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BasketItems_BasketId",
                table: "BasketItems",
                column: "BasketId");

            migrationBuilder.CreateIndex(
                name: "IX_BasketItems_ProductId",
                table: "BasketItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Baskets_AppUserId",
                table: "Baskets",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Offers_AppUserId",
                table: "Offers",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Offers_ProductId",
                table: "Offers",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductProductImageFile_ProductsId",
                table: "ProductProductImageFile",
                column: "ProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_AppUserId",
                table: "Products",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ColorId",
                table: "Products",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SizeId",
                table: "Products",
                column: "SizeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_Orders_OrderId",
                table: "Products_Orders",
                column: "OrderId");
        }
    }
}
