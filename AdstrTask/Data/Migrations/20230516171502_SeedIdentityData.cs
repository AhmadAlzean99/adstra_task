using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AdstrTask.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedIdentityData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
