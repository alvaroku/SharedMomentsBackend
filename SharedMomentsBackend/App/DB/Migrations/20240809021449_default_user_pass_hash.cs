using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SharedMomentsBackend.App.DB.Migrations
{
    /// <inheritdoc />
    public partial class default_user_pass_hash : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("e9a54e41-3d9a-4a93-abb5-a3652846edc2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("27a4b889-3192-4f14-86ca-eebd3e9561b6"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("fabfb63b-9ea6-44aa-85ea-4fe0de75b134"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "IsActive", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("3eaf8e56-a6f0-4764-98d2-eb7a68885a1d"), new DateTime(2024, 8, 9, 2, 14, 48, 860, DateTimeKind.Utc).AddTicks(8075), true, "Admin", new DateTime(2024, 8, 9, 2, 14, 48, 860, DateTimeKind.Utc).AddTicks(8078) },
                    { new Guid("fc78620f-c053-42d6-9b9a-b613fddd860b"), new DateTime(2024, 8, 9, 2, 14, 48, 860, DateTimeKind.Utc).AddTicks(8081), true, "User", new DateTime(2024, 8, 9, 2, 14, 48, 860, DateTimeKind.Utc).AddTicks(8082) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DateOfBirth", "Email", "IsActive", "Name", "PasswordHash", "PhoneNumber", "ProfileId", "RoleId", "UpdatedAt" },
                values: new object[] { new Guid("e239cf18-5acc-417f-b54f-bf1b5d174a55"), new DateTime(2024, 8, 9, 2, 14, 48, 860, DateTimeKind.Utc).AddTicks(8246), new DateTime(2000, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "alvaroku123@gmail.com", true, "Alvaro Kú", "b2867617492e26c338ab49f72afabc984d798b59755a27e312b953716ae964d7", "9919596720", null, new Guid("3eaf8e56-a6f0-4764-98d2-eb7a68885a1d"), new DateTime(2024, 8, 9, 2, 14, 48, 860, DateTimeKind.Utc).AddTicks(8246) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("fc78620f-c053-42d6-9b9a-b613fddd860b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("e239cf18-5acc-417f-b54f-bf1b5d174a55"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("3eaf8e56-a6f0-4764-98d2-eb7a68885a1d"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "IsActive", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("e9a54e41-3d9a-4a93-abb5-a3652846edc2"), new DateTime(2024, 8, 9, 2, 10, 45, 235, DateTimeKind.Utc).AddTicks(122), true, "User", new DateTime(2024, 8, 9, 2, 10, 45, 235, DateTimeKind.Utc).AddTicks(122) },
                    { new Guid("fabfb63b-9ea6-44aa-85ea-4fe0de75b134"), new DateTime(2024, 8, 9, 2, 10, 45, 235, DateTimeKind.Utc).AddTicks(113), true, "Admin", new DateTime(2024, 8, 9, 2, 10, 45, 235, DateTimeKind.Utc).AddTicks(119) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DateOfBirth", "Email", "IsActive", "Name", "PasswordHash", "PhoneNumber", "ProfileId", "RoleId", "UpdatedAt" },
                values: new object[] { new Guid("27a4b889-3192-4f14-86ca-eebd3e9561b6"), new DateTime(2024, 8, 9, 2, 10, 45, 235, DateTimeKind.Utc).AddTicks(305), new DateTime(2000, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "alvaroku123@gmail.com", true, "Alvaro Kú", "hashed_password", "9919596720", null, new Guid("fabfb63b-9ea6-44aa-85ea-4fe0de75b134"), new DateTime(2024, 8, 9, 2, 10, 45, 235, DateTimeKind.Utc).AddTicks(306) });
        }
    }
}
