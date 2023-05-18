using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AdstrTask.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDashboard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7fb5ec32-ab1a-4bd6-8bd5-8834016a695b");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4b08d258-e734-4761-8482-8e8ae83000b6", "8bb4b75a-2e0d-4bb4-a376-4d3799ab4d69" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b08d258-e734-4761-8482-8e8ae83000b6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8bb4b75a-2e0d-4bb4-a376-4d3799ab4d69");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "416e0f8f-73f7-4ead-96f8-8fa072629464", null, "User", "USER" },
                    { "74188461-6878-4ca0-8f94-b58edd191d7b", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "112fa4fd-6ce3-4199-b025-9c8ca0caf081", 0, "22d35a63-2f8e-4af6-b21a-eab42846b359", "Ahmadalzean22@com", true, false, null, null, "AHMADALZEAN22@COM", "AQAAAAIAAYagAAAAEJRRdLtdVqNkF+0tyKw32ZknHdiqqtjD1ks9WuBndMuED+5aSwxbz9bKwQU9CeAskg==", "+111111111111", true, "83403c3b-7e05-40bc-b05f-16bc9368a808", false, "Ahmadalzean22@com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "74188461-6878-4ca0-8f94-b58edd191d7b", "112fa4fd-6ce3-4199-b025-9c8ca0caf081" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "416e0f8f-73f7-4ead-96f8-8fa072629464");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "74188461-6878-4ca0-8f94-b58edd191d7b", "112fa4fd-6ce3-4199-b025-9c8ca0caf081" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "74188461-6878-4ca0-8f94-b58edd191d7b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "112fa4fd-6ce3-4199-b025-9c8ca0caf081");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4b08d258-e734-4761-8482-8e8ae83000b6", null, "Admin", "ADMIN" },
                    { "7fb5ec32-ab1a-4bd6-8bd5-8834016a695b", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8bb4b75a-2e0d-4bb4-a376-4d3799ab4d69", 0, "d181fb77-d94f-4d23-9c00-48c49a641db3", "Ahmadalzean22@com", true, false, null, null, "AHMADALZEAN22@COM", "AQAAAAIAAYagAAAAEHYHlFKt/NWDVq1TSOBnuXWffPOBAR1BgakfTPoKsyH13TCxXYNUvFeslMGNGG6+tQ==", "+111111111111", true, "8dd0bb69-a5b7-4d6a-b903-c92982db0303", false, "Ahmadalzean22@com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4b08d258-e734-4761-8482-8e8ae83000b6", "8bb4b75a-2e0d-4bb4-a376-4d3799ab4d69" });
        }
    }
}
