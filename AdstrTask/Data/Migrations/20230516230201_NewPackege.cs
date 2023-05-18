using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AdstrTask.Data.Migrations
{
    /// <inheritdoc />
    public partial class NewPackege : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12568117-3793-4bcf-986b-6dc90176dcd2");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b14aa52c-c0db-4124-9186-ece595fbe3ab", "f54528fc-3789-4104-a8a7-544a42861c57" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b14aa52c-c0db-4124-9186-ece595fbe3ab");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f54528fc-3789-4104-a8a7-544a42861c57");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "12568117-3793-4bcf-986b-6dc90176dcd2", null, "User", "USER" },
                    { "b14aa52c-c0db-4124-9186-ece595fbe3ab", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f54528fc-3789-4104-a8a7-544a42861c57", 0, "346c41ef-8324-446b-a04a-6584390e3c36", "Ahmadalzean22@com", true, false, null, null, "AHMADALZEAN22@COM", "AQAAAAIAAYagAAAAEMu8X+jGZOM7tDTzjqt/+WlmMNWtGxQ52ucSErPS0600aawP9YyPscH+Br2mUxW+aw==", "+111111111111", true, "54b1b423-43aa-434b-bd7f-e44101668406", false, "Ahmadalzean22@com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b14aa52c-c0db-4124-9186-ece595fbe3ab", "f54528fc-3789-4104-a8a7-544a42861c57" });
        }
    }
}
