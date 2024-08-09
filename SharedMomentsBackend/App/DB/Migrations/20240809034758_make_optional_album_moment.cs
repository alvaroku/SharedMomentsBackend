using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SharedMomentsBackend.App.DB.Migrations
{
    /// <inheritdoc />
    public partial class make_optional_album_moment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Moments_Albums_AlbumId",
                table: "Moments");

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

            migrationBuilder.AlterColumn<Guid>(
                name: "AlbumId",
                table: "Moments",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "CreatedAt", "IsActive", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("110c5b56-8453-49a4-bdd7-ced7aba73090"), new DateTime(2024, 8, 9, 3, 47, 57, 625, DateTimeKind.Utc).AddTicks(4754), true, "Admin", new DateTime(2024, 8, 9, 3, 47, 57, 625, DateTimeKind.Utc).AddTicks(4757) },
                    { new Guid("6edbaad5-aea0-4970-9b14-42b14add76db"), new DateTime(2024, 8, 9, 3, 47, 57, 625, DateTimeKind.Utc).AddTicks(4759), true, "User", new DateTime(2024, 8, 9, 3, 47, 57, 625, DateTimeKind.Utc).AddTicks(4760) }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "CreatedAt", "DateOfBirth", "Email", "IsActive", "Name", "PasswordHash", "PhoneNumber", "ProfileId", "RoleId", "UpdatedAt" },
                values: new object[] { new Guid("7bbece95-f005-463a-ae50-f40551e72fa5"), new DateTime(2024, 8, 9, 3, 47, 57, 625, DateTimeKind.Utc).AddTicks(4904), new DateTime(2000, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "alvaroku123@gmail.com", true, "Alvaro Kú", "b2867617492e26c338ab49f72afabc984d798b59755a27e312b953716ae964d7", "9919596720", null, new Guid("110c5b56-8453-49a4-bdd7-ced7aba73090"), new DateTime(2024, 8, 9, 3, 47, 57, 625, DateTimeKind.Utc).AddTicks(4905) });

            migrationBuilder.AddForeignKey(
                name: "FK_Moments_Albums_AlbumId",
                table: "Moments",
                column: "AlbumId",
                principalTable: "Albums",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Moments_Albums_AlbumId",
                table: "Moments");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6edbaad5-aea0-4970-9b14-42b14add76db"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("7bbece95-f005-463a-ae50-f40551e72fa5"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("110c5b56-8453-49a4-bdd7-ced7aba73090"));

            migrationBuilder.AlterColumn<Guid>(
                name: "AlbumId",
                table: "Moments",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Moments_Albums_AlbumId",
                table: "Moments",
                column: "AlbumId",
                principalTable: "Albums",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
