using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreApp.Migrations
{
    public partial class RegisterDtoUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80a52a1a-6e7e-4dae-a2b1-3f99dd0aa957");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bf0341da-f83d-4436-9c48-0fab4d066fe0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc0938bd-eace-48bd-9966-5df9e96cc123");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "17bd8140-187e-4116-bab4-db99079b512e", "68eb25eb-9f81-4c9b-93c1-0b3688de6b2b", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a6ee998d-184f-4b53-a4f7-2fff3a444269", "221be39c-44e7-41ef-ad27-977a9fdfcae9", "Editor", "EDITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c6f5d7e2-d409-471f-a34d-c4b9462bf8e2", "4a430905-963e-496a-9fbb-3ff61ec0c898", "User", "USER" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "17bd8140-187e-4116-bab4-db99079b512e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a6ee998d-184f-4b53-a4f7-2fff3a444269");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c6f5d7e2-d409-471f-a34d-c4b9462bf8e2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "80a52a1a-6e7e-4dae-a2b1-3f99dd0aa957", "c9100850-f28e-43fb-9827-68d0bd9a36e3", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bf0341da-f83d-4436-9c48-0fab4d066fe0", "32232ecb-58c4-4ecf-bfd3-37fa5a4d5200", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "fc0938bd-eace-48bd-9966-5df9e96cc123", "bca51b2a-65cc-4aff-ad31-b14150a36c04", "Editor", "EDITOR" });
        }
    }
}
