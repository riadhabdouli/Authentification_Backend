using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    public partial class riadh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "6ffb1668-dddf-4059-9ed4-30ad209ff0d2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "f40c9353-e6aa-4c4e-9d35-54561aa6892c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f6b8cb7d-a7ab-4cd4-a69d-feaf90c14084", "AQAAAAEAACcQAAAAEOMfDhoL92w0eg94WSNK0qdqsiZ4gmvcUk2NdXpQNFvjDG32EcHlrPmJLZY3SDV5hg==", "b7822267-5fe3-43b9-9152-910d63ebd39c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f3ee0a02-0065-480a-a367-139cfa83c225", "AQAAAAEAACcQAAAAEGTseNDKKx0uePTANKtLSjCedARn9gfWRADg/B8MuVBQQEai8c5OyYxoV1zdXPP+nw==", "e633be65-3b0a-4bb9-89dc-93b00f23d019" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "678a702f-ff70-4ff6-a10f-37cb99b7252e", "AQAAAAEAACcQAAAAEC0m/hhWAIStCoDSZbgKs+VHcNsRWB47LEZHPLGnR0s0dTpucw2QsFHkLBo7sPiJPA==", "0392de8b-e9d0-491e-b5cd-506e709f10a9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "618351ec-9b2e-41d9-82c7-f2905612edf9", "AQAAAAEAACcQAAAAEDDssodahdIr2YtB7NMdbVocLDXMNZKYGuvTzlycWgzYcifMS/GnJNTXoM8NO0HOSw==", "55323e1e-d5a5-4b17-8c9f-834d00a761ca" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2bba985c-8076-4f9e-b675-16fb4c8795f7", "AQAAAAEAACcQAAAAEGMDeCu6w4jK1lcISjBYbGHdSADAhSipUO6TVJXRDLOQug/WOZdw0AsywKv3HKbC3g==", "f3f994d0-f48c-4023-89e6-fa29d9c6c286" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "141bdc61-b80b-4f61-a022-eb79d7c2c166", "AQAAAAEAACcQAAAAEFoajWIjrX1O7zMYqGLsCKx/iYfG+K6MPIbIRXNa6zQmVykosbn51+XQg2h9if2uaA==", "3517814f-d424-4c4a-8d98-73436777f5fa" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c7088e8-6f2d-4aea-af96-c48b9d6491ec", "AQAAAAEAACcQAAAAEFmq7WwP1+I7MEyhMOxbfZ53XyTQMUHrFzqxYl4Vk1vQa/iMXr/DX98g6EyCYHlF5g==", "6133c290-212f-44dd-bb59-daa2cc381a8e" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6487b072-c376-40f0-ac45-d037138ebcb2", "AQAAAAEAACcQAAAAEJ/2tNCZohCCyOBuwCZmrdOCRfiF5BVnDPgBs1JVQC54aBvThaPKypUjgTA0+uzujg==", "217eeafb-11f5-4b50-8084-54f3b3c5713c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "85e3914a-e370-4660-9854-b4dec9418044", "AQAAAAEAACcQAAAAEDe7lTVVAAIxGCBQB1nG/IVPzIK5UjKnwK113G9UDT7foRyF8M/qvIxoeH8PbNj3rg==", "25dd280b-d561-4c6e-b76a-ebd51485174e" });
        }
    }
}
